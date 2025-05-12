using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<string> calisanListesi = new List<string>();
        private Queue<string> islemKuyrugu = new Queue<string>();
        private Stack<string> geriAlStack = new Stack<string>();
        private Hashtable pozisyonTablosu = new Hashtable();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false; // istersen

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AyarlaButon(btnSil, Color.LightCoral, Color.Tomato, Color.IndianRed);
            AyarlaButon(btnCalisanEkle, Color.SteelBlue, Color.RoyalBlue, Color.MidnightBlue);
            AyarlaButon(btnGuncelle, Color.SteelBlue, Color.RoyalBlue, Color.MidnightBlue);
            AyarlaButon(btnAra, Color.SteelBlue, Color.RoyalBlue, Color.MidnightBlue);
            AyarlaButon(btnDepartmanEkle, Color.SteelBlue, Color.RoyalBlue, Color.MidnightBlue);
            AyarlaButon(btnGecmisiGoster, Color.SteelBlue, Color.RoyalBlue, Color.MidnightBlue);
            AyarlaButon(btnGeriAl, Color.MediumSlateBlue, Color.SlateBlue, Color.DarkSlateBlue);

            this.Text = "lë pőzisyoñ de Yuńis";

            TreeNode ceoNode = new TreeNode("Ahmet Yılmaz - CEO");
            TreeNode finans = new TreeNode("Finans Departmanı");
            finans.Nodes.Add(new TreeNode("Fatma Güneş - Muhasebeci"));
            TreeNode yazilim = new TreeNode("Yazılım Departmanı");
            yazilim.Nodes.Add(new TreeNode("Mehmet Kara - Yazılımcı"));
            ceoNode.Nodes.Add(finans);
            ceoNode.Nodes.Add(yazilim);
            treeView1.Nodes.Add(ceoNode);
            treeView1.ExpandAll();
        }

        private void AyarlaButon(Button btn, Color backColor, Color hoverColor, Color downColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.FlatAppearance.MouseOverBackColor = hoverColor;
            btn.FlatAppearance.MouseDownBackColor = downColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string ad = txtAdSoyad.Text.Trim();
                string pozisyon = txtPozisyon.Text.Trim();

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(pozisyon))
                {
                    MessageBox.Show("Lütfen ad ve pozisyon giriniz.");
                    return;
                }

                TreeNode yeniCalisan = new TreeNode($"{ad} - {pozisyon}");
                treeView1.SelectedNode.Nodes.Add(yeniCalisan);
                treeView1.SelectedNode.Expand();

                // ✅ ListBox'a ekle
                listBoxCalisanlar.Items.Add(ad);

                // ✅ Arka plandaki veri yapılarını da güncelle
                calisanListesi.Add(ad);
                islemKuyrugu.Enqueue($"Ekle: {ad}");
                geriAlStack.Push($"Sil: {ad}");
                pozisyonTablosu[ad] = pozisyon;
            }
            else
            {
                MessageBox.Show("Lütfen bir departman ya da yönetici seçiniz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string ad = txtAdSoyad.Text.Trim();
                string pozisyon = txtPozisyon.Text.Trim();

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(pozisyon))
                {
                    MessageBox.Show("Lütfen yeni ad ve pozisyon giriniz.");
                    return;
                }

                treeView1.SelectedNode.Text = $"{ad} - {pozisyon}";
                pozisyonTablosu[ad] = pozisyon;
                islemKuyrugu.Enqueue($"Güncelle: {ad}");
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek çalışanı seçiniz.");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim().ToLower(new CultureInfo("tr-TR"));

            if (string.IsNullOrWhiteSpace(aranan))
            {
                MessageBox.Show("Lütfen bir isim ya da pozisyon giriniz.");
                return;
            }

            TreeNode bulunan = null;

            foreach (TreeNode rootNode in treeView1.Nodes)
            {
                bulunan = AraTumu(rootNode, aranan);
                if (bulunan != null)
                    break;
            }

            if (bulunan != null)
            {
                treeView1.SelectedNode = bulunan;
                bulunan.EnsureVisible();
                labelSonuc.Text = $"🔍Bulunan: {bulunan.Text}";
            }
            else
            {
                labelSonuc.Text = "❌ Aranan kişi bulunamadı.";
                MessageBox.Show("Aranan kişi bulunamadı.");
            }

        }

        private TreeNode AraTumu(TreeNode node, string aranan)
        {
            string nodeText = node.Text.ToLower(new CultureInfo("tr-TR"));

            if (nodeText.Contains(aranan))
                return node;

            foreach (TreeNode altNode in node.Nodes)
            {
                TreeNode bulunan = AraTumu(altNode, aranan);
                if (bulunan != null)
                    return bulunan;
            }

            return null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string nodeText = treeView1.SelectedNode.Text;
                DialogResult sonuc = MessageBox.Show("Seçili düğümü silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    // 🔍 Çalışan mı, departman mı kontrol et
                    if (nodeText.Contains("-")) // Çalışan
                    {
                        string ad = nodeText.Split('-')[0].Trim();
                        string pozisyon = nodeText.Split('-')[1].Trim();
                        string departman = treeView1.SelectedNode.Parent.Text.Trim();

                        // Stack'e geri alma için bilgi ekle
                        geriAlStack.Push($"{ad}|{pozisyon}|{departman}");

                        // TreeView'den ve listelerden sil
                        treeView1.SelectedNode.Remove();
                        listBoxCalisanlar.Items.Remove(ad);
                        calisanListesi.Remove(ad);
                        pozisyonTablosu.Remove(ad);
                        islemKuyrugu.Enqueue($"Sil: {ad}");
                    }
                    else // Departman siliniyor
                    {
                        // Geri alınamayacak şekilde sadece kaldır
                        treeView1.SelectedNode.Remove();
                        MessageBox.Show("Departman silindi. Geri alınamaz.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz çalışan ya da departmanı seçin.");
            }
        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string departmanAdi = Interaction.InputBox("Yeni departman adını giriniz:", "Departman Ekle", "Yeni Departman");

                if (!string.IsNullOrWhiteSpace(departmanAdi))
                {
                    TreeNode yeniDepartman = new TreeNode(departmanAdi);
                    treeView1.SelectedNode.Nodes.Add(yeniDepartman);
                    treeView1.SelectedNode.Expand();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir yönetici veya ana düğüm seçiniz.");
            }
        }

        private void listBoxCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCalisanlar.SelectedItem != null)
            {
                string secilenAd = listBoxCalisanlar.SelectedItem.ToString();

                if (pozisyonTablosu.ContainsKey(secilenAd))
                {
                    labelPozisyon.Text = "Pozisyon: " + pozisyonTablosu[secilenAd].ToString();
                }
                else
                {
                    labelPozisyon.Text = "Pozisyon: (bulunamadı)";
                }
            }
        }

        private void btnGecmisiGoster_Click(object sender, EventArgs e)
        {
            listBoxIslemGecmisi.Items.Clear();

            foreach (string islem in islemKuyrugu)
            {
                listBoxIslemGecmisi.Items.Add(islem);
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (geriAlStack.Count > 0)
            {
                string[] bilgiler = geriAlStack.Pop().Split('|');

                if (bilgiler.Length == 3)
                {
                    string ad = bilgiler[0];
                    string pozisyon = bilgiler[1];
                    string departmanAdi = bilgiler[2];

                    // Doğru departmanı bul
                    TreeNode hedefDepartman = AraDepartman(treeView1.Nodes[0], departmanAdi);

                    if (hedefDepartman != null)
                    {
                        TreeNode geriNode = new TreeNode($"{ad} - {pozisyon}");
                        hedefDepartman.Nodes.Add(geriNode);
                        listBoxCalisanlar.Items.Add(ad);
                        pozisyonTablosu[ad] = pozisyon;
                    }
                }
            }
            else
            {
                MessageBox.Show("Geri alınacak işlem yok.");
            }
        }
        private TreeNode AraDepartman(TreeNode node, string aranan)
        {
            if (node.Text.Trim() == aranan.Trim())
                return node;

            foreach (TreeNode altNode in node.Nodes)
            {
                TreeNode bulunan = AraDepartman(altNode, aranan);
                if (bulunan != null)
                    return bulunan;
            }
            return null;
        }

        private void labelSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
