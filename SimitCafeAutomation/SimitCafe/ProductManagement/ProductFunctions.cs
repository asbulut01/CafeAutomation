using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SimitCafe.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using Guna.UI2.WinForms;

namespace SimitCafe.ProductManagement
{
    public static class ProductFunctions
    {
        public static void UrunEkle(int urunAdet, int masaNo, string urunAdi, double urunFiyati, DateTime tarih, double toplamFiyat)
        {
            toplamFiyat = urunAdet * urunFiyati;

            using (OleDbCommand command = new OleDbCommand("Insert Into UrunListesi(Adet,MasaNo,UrunAdi,UrunFiyati,Tarih,ToplamFiyat) values(@adet,@masaNo,@urunAdi,@urunFiyati,@tarih,@toplamFiyat)", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"adet", urunAdet);
                command.Parameters.AddWithValue(@"masaNo", masaNo);
                command.Parameters.AddWithValue(@"urunAdi", urunAdi);
                command.Parameters.AddWithValue(@"urunFiyati", urunFiyati);
                command.Parameters.AddWithValue(@"tarih", tarih);
                command.Parameters.AddWithValue(@"toplamFiyat", toplamFiyat);

                command.ExecuteNonQuery();
            }
        }

        public static void UrunKaldir(string urunAdi, Label label)
        {
            using (OleDbCommand command = new OleDbCommand("Select * From UrunListesi Where UrunNo=@urunNo", ConnectDB.connection))
            {
                command.Parameters.AddWithValue("@urunNo", urunAdi);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reader.Close();

                        using (OleDbCommand command2 = new OleDbCommand("Delete From UrunListesi Where UrunNo=@urunNo", ConnectDB.connection))
                        {
                            command2.Parameters.AddWithValue("@urunNo", urunAdi);
                            command2.ExecuteNonQuery();

                            label.Visible = true;
                            label.ForeColor = Color.Green;

                            label.Text = "Ürün Başarıyla Silindi :)";
                        }
                    }
                    else
                    {
                        label.Visible = true;
                        label.ForeColor = Color.Red;

                        label.Text = "Bu Ürün Mevcut Değil";
                    }
                }
            }
        }

        public static void MenuKaldir(int urunNo, Label label)
        {
            using (OleDbCommand command = new OleDbCommand("Select * From Menu Where UrunNo=@urunNo", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"urunNo", urunNo);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reader.Close();

                        using (OleDbCommand command2 = new OleDbCommand("Delete From Menu Where UrunNo=@urunNo", ConnectDB.connection))
                        {
                            command2.Parameters.AddWithValue(@"urunNo", urunNo);
                            command2.ExecuteNonQuery();

                            label.Visible = true;
                            label.ForeColor = Color.Green;

                            label.Text = "Ürün Başarıyla Silindi :)";
                        }
                    }
                    else
                    {
                        label.Visible = true;
                        label.ForeColor = Color.Red;

                        label.Text = "Bu Ürün Mevcut Değil";
                    }
                }
            }
        }

        public static void UrunGuncelle(string urunNo, string yeniUrunAdi, double yeniUrunFiyati, Label label)
        {
            using (OleDbCommand command = new OleDbCommand("Select Count(*) From UrunListesi Where UrunNo=@urunNo", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"urunNo", urunNo);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    using (OleDbCommand command2 = new OleDbCommand("Update UrunListesi Set UrunAdi=@yeniUrunAdi, UrunFiyati=@yeniUrunFiyati Where UrunNo=@urunNo", ConnectDB.connection))
                    {
                        command2.Parameters.AddWithValue(@"yeniUrunAdi", yeniUrunAdi);
                        command2.Parameters.AddWithValue(@"yeniUrunFiyati", yeniUrunFiyati);
                        command2.Parameters.AddWithValue(@"urunNo", urunNo);

                        command2.ExecuteNonQuery();

                        label.Visible = true;
                        label.ForeColor = Color.Green;
                        label.Text = "Ürün Başarıyla Güncellendi :)";
                    }
                }
                else
                {
                    label.Visible = true;
                    label.ForeColor = Color.Red;
                    label.Text = "Bu Ürün Mevcut Değil.";
                }
            }
        }

        public static void MenuGuncelle(string urunNo, string yeniUrunAdi, string yeniUrunFiyati, Label label)
        {
            using (OleDbCommand command = new OleDbCommand("Select Count(*) From Menu Where UrunNo=@urunNo", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"urunNo", urunNo);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    using (OleDbCommand command2 = new OleDbCommand("Update Menu Set UrunAdi=@urunAdi, UrunFiyati=@urunFiyati Where UrunNo=@urunNo", ConnectDB.connection))
                    {
                        command2.Parameters.AddWithValue(@"urunAdi", yeniUrunAdi);
                        command2.Parameters.AddWithValue(@"urunFiyati", yeniUrunFiyati);
                        command2.Parameters.AddWithValue(@"urunNo", urunNo);

                        command2.ExecuteNonQuery();

                        label.Visible = true;
                        label.ForeColor = Color.Green;

                        label.Text = "Ürün Başarıyla Güncellendi :)";
                    }
                }
                else
                {
                    label.Visible = true;
                    label.ForeColor = Color.Red;

                    label.Text = "Bu Ürün Mevcut Değil.";
                }
            }
        }

        public static DataTable UrunListele()
        {
            using (OleDbCommand command = new OleDbCommand("Select * From UrunListesi", ConnectDB.connection))
            {
                DataTable dataTable = new DataTable();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static DataTable MenuyuListele()
        {
            using (OleDbCommand command = new OleDbCommand("Select * From Menu", ConnectDB.connection))
            {
                DataTable dataTable = new DataTable();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static void MenuEkle(string urunAdi, string urunFiyati, Label label)
        {
            using (OleDbCommand command = new OleDbCommand("Select * From Menu Where UrunAdi=@urunAdi", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"urunAdi", urunAdi);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label.Visible = true;
                        label.ForeColor = Color.Red;

                        label.Text = "Bu Ürün Zaten Mevcut";
                    }
                    else
                    {
                        using (OleDbCommand commandUser = new OleDbCommand("Insert Into Menu(UrunAdi,UrunFiyati) values(@urunAdi,@urunFiyati)", ConnectDB.connection))
                        {
                            commandUser.Parameters.AddWithValue(@"urunAdi", urunAdi);
                            commandUser.Parameters.AddWithValue(@"urunFiyati", urunFiyati);

                            commandUser.ExecuteNonQuery();

                            label.Visible = true;
                            label.ForeColor = Color.Green;

                            label.Text = "Ürün Başarıyla Eklendi :)";
                        }
                    }
                }
            }
        }

        public static double ToplamFiyat(double urunFiyat, int urunAdet)
        {
            double toplamFiyat = urunFiyat * urunAdet;

            using (OleDbCommand command = new OleDbCommand("Insert Into UrunListesi(ToplamFiyat) values(@toplamFiyat)", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"toplamFiyat", toplamFiyat);
                command.ExecuteNonQuery();

                return toplamFiyat;
            }
        }

        public static void MasaDoluMu(List<Button> buttons)
        {
            using (OleDbCommand command = new OleDbCommand("SELECT MasaNo FROM UrunListesi", ConnectDB.connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    foreach (Button button in buttons)
                    {
                        button.Text = "Boş";
                        button.BackColor = Color.Green;
                        button.ForeColor = Color.White;
                    }

                    while (reader.Read())
                    {
                        int masaNo = reader.GetInt32(0) - 1; // Veritabanındaki MasaNo'yu al ve 1 azalt

                        if (masaNo >= 0 && masaNo < buttons.Count)
                        {
                            buttons[masaNo].Text = "Dolu";
                            buttons[masaNo].BackColor = Color.DarkRed;
                            buttons[masaNo].ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        public static void MasaNoKaldir(int masaNo, Label label)
        {
            using (OleDbCommand command = new OleDbCommand("Select * From UrunListesi Where MasaNo=@masaNo", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"masaNo", masaNo);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        using (OleDbCommand command2 = new OleDbCommand("Delete From UrunListesi Where MasaNo=@masaNo", ConnectDB.connection))
                        {
                            command2.Parameters.AddWithValue(@"masaNo", masaNo);
                            command2.ExecuteNonQuery();

                            label.Visible = true;
                            label.Text = "Ürün Başarıyla Silindi :)";
                            label.ForeColor = Color.Green;
                        }
                    }
                    else
                    {
                        label.Visible = true;
                        label.Text = "Ürün Mevcut Değil.";
                        label.ForeColor = Color.DarkRed;
                    }
                }
            }
        }

        public static void MasaNoyaGoreGetir(int masaNo, TextBox textBox, TextBox textBox2)
        {
            using (OleDbCommand command = new OleDbCommand("Select * From UrunListesi Where MasaNo=@masaNo", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"masaNo", masaNo);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox.Text = reader["ToplamFiyat"].ToString();
                        textBox2.Enabled = true;
                    }
                    else
                    {
                        textBox.Text = "Bu Masa Mevcut Değil..";
                        textBox2.Enabled = false;
                    }
                }
            }
        }

        public static void HesabiOde(double odenecek)
        {
            using (OleDbCommand command = new OleDbCommand("Select * From UrunListesi Where ToplamFiyat=@toplamFiyat", ConnectDB.connection))
            {
                command.Parameters.AddWithValue(@"toplamFiyat", odenecek);

                using (OleDbCommand command2 = new OleDbCommand("Delete From UrunListesi Where ToplamFiyat=@toplamFiyat", ConnectDB.connection))
                {
                    command2.Parameters.AddWithValue(@"toplamFiyat", odenecek);
                    command2.ExecuteNonQuery();
                }
            }
        }
    }
}