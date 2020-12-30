using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veritabaniproje.Models;

namespace veritabaniproje.Helpers
{

    public class Api
    {

        private string _urlDB = "Server=localhost;Port=5432;User Id=postgres;Password=aysisava;Database=HastaneTakipDB";

        public Api()
        {

        }

        public NpgsqlConnection CreateConnection
        {
            get
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(_urlDB);
                    return conn;
                }
                catch
                {
                    Console.WriteLine("Acik baglantı var veya baglanti gerceklesemedi");
                    return null;
                }
            }
        }



        public List<Sehir> GetSehirler()
        {
            var list = new List<Sehir>();

            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM \"public\".\"Sehir\"", conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Sehir();
                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        list.Add(model);
                    }
                    reader.Close();
                }

            }
            if (list.Count > 0)
                return list;
            else
                return null;
        }

        /// <summary>
        /// Giriş yapma fonksiyonu
        /// </summary>
        /// <param name="tckn">tc kimlik no</param>
        /// <param name="password">parola</param>
        /// <returns>Dönüş değeri null ise böyle bir kullanıcı yoktur.</returns>
        public User LoginUser(string tckn, string password)
        {
            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"User\" WHERE \"Tckn\" = '{0}' AND \"Password\" = '{1}'", tckn, password);
                User user = new User();
                using (var cmd = new NpgsqlCommand(q1, conn))
                {

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.AdSoyad = reader.GetString(1);
                        user.Tckn = reader.GetString(2);
                        user.Password = reader.GetString(3);
                        user.SehirId = reader.GetInt32(4);
                    }
                    reader.Close();
                }
                return user.Id != null ? user : null;

            }
        }
        public int GetSehirId(string name)
        {
            int Id = -1;
            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                string query = String.Format("SELECT * FROM \"public\".\"Sehir\" WHERE \"Name\" = '{0}' ", name);
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Id = reader.GetInt32(0);
                        var Name = reader.GetString(1);

                    }
                    reader.Close();
                }

            }
            return Id;
        }

        public bool RegisterUser(User model)
        {
            if (model.SehirId == null || model.SehirId == -1)
            {
                model.SehirId = 34;
            }
            int nRows = -1;
            using (var conn = CreateConnection)

            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                int count = -1;
                using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM \"public\".\"User\"", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                model.Id = count + 1;
                using (var command = new NpgsqlCommand("INSERT INTO \"public\".\"User\" (\"Id\",\"AdSoyad\",\"Tckn\",\"Password\",\"SehirId\")\n Values(@q1, @q2,@q3,@q4,@q5)", conn))
                {
                    command.Parameters.AddWithValue("q1", model.Id);
                    command.Parameters.AddWithValue("q2", model.AdSoyad);
                    command.Parameters.AddWithValue("q3", model.Tckn);
                    command.Parameters.AddWithValue("q4", model.Password);
                    command.Parameters.AddWithValue("q5", model.SehirId);

                    nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
            }

            return nRows == 1;
        }

        public bool AddChild(Cocuk model, string EbeveynTc)
        {
            using (var conn = CreateConnection)

            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"User\" WHERE \"Tckn\"= '{0}' ", EbeveynTc);
                int EbevynId = -1;
                using (var command = new NpgsqlCommand(q1, conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        EbevynId = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                if (EbevynId == -1) return false;
                model.EbeveynId = EbevynId;
                int count = -1;
                using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM \"public\".\"Cocuk\"", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                model.Id = count + 1;
                int nRows = -1;
                using (var command = new NpgsqlCommand("INSERT INTO \"public\".\"Cocuk\" (\"Id\",\"EbeveynId\",\"AdSoyad\")\n Values(@q1, @q2,@q3)", conn))
                {
                    command.Parameters.AddWithValue("q1", model.Id);
                    command.Parameters.AddWithValue("q2", model.EbeveynId);
                    command.Parameters.AddWithValue("q3", model.AdSoyad);

                    nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
                return nRows == 1;
            }
        }

        public Duyuru GetDuyuru(int id, out Kaynak kaynak)
        {
            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Duyuru\" WHERE \"Id\" ={0}", id);
                var duyuru = new Duyuru();
                using (var cmd = new NpgsqlCommand(q1, conn))
                {

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        duyuru.Id = reader.GetInt32(0);
                        duyuru.Text = reader.GetString(1);
                        duyuru.KaynakId = reader.GetInt32(2);
                    }
                    reader.Close();
                }
                string q2 = String.Format("SELECT * FROM \"public\".\"Kaynak\" WHERE \"Id\" ={0}", duyuru.KaynakId);
                kaynak = new Kaynak();
                using (var cmd = new NpgsqlCommand(q2, conn))
                {

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        kaynak.Id = reader.GetInt32(0);
                        kaynak.Name = reader.GetString(1);

                    }
                    reader.Close();
                }

                return duyuru.Id != 0 ? duyuru : null;
            }
        }

        public List<Hastane> GetHastanes()
        {
            var list = new List<Hastane>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT \"Id\" ,\"Name\", \"SehirId\" FROM \"public\".\"Hastane\" Inner JOIN \"public\".\"SaglikKurumu\" ON \"SkId\" = \"Id\"", conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Hastane();

                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.SehirId = reader.GetInt32(2);

                        if (Constants.user != null)
                        {
                            if (model.SehirId == Constants.user.SehirId)
                            {
                                list.Add(model);
                            }
                        }

                    }
                }

                return list.Count > 0 ? list : null;
            }
        }

        public List<Bolum> GetBolum(int HastaneId)
        {
            var list = new List<Bolum>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Bolum\" WHERE \"SkId\" = '{0}'", HastaneId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Bolum();

                        model.Id = reader.GetInt32(0);
                        model.SkId = reader.GetInt32(1);
                        model.Name = reader.GetString(2);


                        list.Add(model);


                    }
                }

                return list.Count > 0 ? list : null;
            }
        }

        public int GetHastaneId(string name)
        {
            int Id = -1;
            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                string query = String.Format("SELECT * FROM \"public\".\"Hastane\" Inner JOIN \"public\".\"SaglikKurumu\" ON \"SkId\" = \"Id\" WHERE \"Name\" = '{0}' ", name);
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Id = reader.GetInt32(0);


                    }
                    reader.Close();
                }

            }
            return Id;
        }

        public List<Doktor> GetDoktor(int BolumId, int SKId)
        {
            var list = new List<Doktor>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Doktor\" INNER JOIN \"public\".\"Bolum\" ON \"BolumId\" = \"public\".\"Bolum\".\"Id\" WHERE \"BolumId\" = '{0}'", BolumId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Doktor();
                        var bolum = new Bolum();


                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.BolumId = reader.GetInt32(2);
                        model.PuanId = reader.GetInt32(3);
                        model.BosTarihBas = reader.GetString(5);
                        model.BosTarihSon = reader.GetString(6);
                        model.BosSaatBas = reader.GetString(7);
                        model.BosSaatSon = reader.GetString(8);
                        bolum.Id = reader.GetInt32(9);
                        bolum.SkId = reader.GetInt32(10);
                        bolum.Name = reader.GetString(11);

                        if (bolum.SkId == SKId)
                        {
                            list.Add(model);

                        }



                    }
                }

                return list.Count > 0 ? list : null;
            }
        }

        public int GetBolumId(string name, int skId)
        {
            int Id = -1;
            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                string query = String.Format("SELECT * FROM \"public\".\"Bolum\"  WHERE \"Name\" = '{0}' ", name);
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var skID = reader.GetInt32(1);
                        if (skId == skID)
                        {
                            Id = reader.GetInt32(0);
                        }



                    }
                    reader.Close();
                }

            }
            return Id;
        }

        public List<ASM> GetASM()
        {
            var list = new List<ASM>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT \"Id\" ,\"Name\", \"SehirId\" FROM \"public\".\"ASM\" Inner JOIN \"public\".\"SaglikKurumu\" ON \"SkId\" = \"Id\"", conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new ASM();

                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.SehirId = reader.GetInt32(2);

                        if (Constants.user != null)
                        {
                            if (model.SehirId == Constants.user.SehirId)
                            {
                                list.Add(model);
                            }
                        }

                    }
                }

                return list.Count > 0 ? list : null;
            }
        }
        public List<Mah> GetMah(int HastaneId)
        {
            var list = new List<Mah>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Mah\" WHERE \"SkId\" = '{0}'", HastaneId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Mah();

                        model.Id = reader.GetInt32(0);
                        model.SkId = reader.GetInt32(1);
                        model.Name = reader.GetString(2);


                        list.Add(model);


                    }
                }

                return list.Count > 0 ? list : null;
            }
        }

        public int GetAsmId(string name)
        {
            int Id = -1;
            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                string query = String.Format("SELECT * FROM \"public\".\"ASM\" Inner JOIN \"public\".\"SaglikKurumu\" ON \"SkId\" = \"Id\" WHERE \"Name\" = '{0}' ", name);
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Id = reader.GetInt32(0);


                    }
                    reader.Close();
                }

            }
            return Id;
        }

        public List<Doktor> GetDoktorAsm(int MahId)
        {
            var list = new List<Doktor>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Doktor\" WHERE \"MahId\" = '{0}'", MahId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Doktor();

                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.PuanId = reader.GetInt32(3);
                        model.MahId = reader.GetInt32(4);
                        model.BosTarihBas = reader.GetString(5);
                        model.BosTarihSon = reader.GetString(6);
                        model.BosSaatBas = reader.GetString(7);
                        model.BosSaatSon = reader.GetString(8);



                        list.Add(model);


                    }
                }

                return list.Count > 0 ? list : null;
            }
        }


        public int GetMahId(string name)
        {
            int Id = -1;
            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                string query = String.Format("SELECT * FROM \"public\".\"Mah\"  WHERE \"Name\" = '{0}' ", name);
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Id = reader.GetInt32(0);


                    }
                    reader.Close();
                }

            }
            return Id;
        }

        public List<Cocuk> GetCocuk(int ebeveynId)
        {

            var list = new List<Cocuk>();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Cocuk\" WHERE \"EbeveynId\" = '{0}'", ebeveynId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Cocuk();

                        model.Id = reader.GetInt32(0);
                        model.EbeveynId = reader.GetInt32(1);
                        model.AdSoyad = reader.GetString(2);

                        list.Add(model);

                    }
                }
                return list.Count > 0 ? list : null;
            }
        }

        public Doktor GetDoktorFromName(string name)
        {
            Doktor model;
            model = new Doktor();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Doktor\" WHERE \"Name\"='{0}'", name);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        

                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.BolumId = reader.GetInt32(2);
                        model.PuanId = reader.GetInt32(3);                   
                        model.BosTarihBas = reader.GetString(5);
                        model.BosTarihSon = reader.GetString(6);
                        model.BosSaatBas = reader.GetString(7);
                        model.BosSaatSon = reader.GetString(8);

                        
                    }
                }

                return model;


            }


        }

        public bool RandevuOlustur(Randevu randevu)
        {

            using (var conn = CreateConnection)
            {
                conn.Open();

                int count = 0;
                using (var command = new NpgsqlCommand("SELECT MAX(\"Id\") FROM \"public\".\"Randevu\"", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            count = reader.GetInt32(0);

                        }
                        catch
                        {

                            
                        }
                       
                    }
                    reader.Close();
                }


                int id = count + 1;
                randevu.Id = id;
                int nRows = -1;

                using (var cmd = new NpgsqlCommand("SELECT * FROM RandevuOlustur(@q1,@q2,@q3,@q4,@q5,@q6)", conn))
                {
                    cmd.Parameters.AddWithValue("q1", randevu.Id);
                    cmd.Parameters.AddWithValue("q2", randevu.Tarih);
                    cmd.Parameters.AddWithValue("q3", randevu.DoktorId);
                    cmd.Parameters.AddWithValue("q4", randevu.UserId);
                    cmd.Parameters.AddWithValue("q5", randevu.SaglikKurumuId);
                    cmd.Parameters.AddWithValue("q6", randevu.Saat);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nRows = 1;

                    }
                   // nRows = cmd.ExecuteNonQuery();


                }

                return nRows==1 ;


            }



        }


        public Doktor GetDoktorAsmFromName(string name)
        {
            Doktor model;
            model = new Doktor();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Doktor\" WHERE \"Name\"='{0}'", name);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.PuanId = reader.GetInt32(3);
                        model.MahId = reader.GetInt32(4);
                        model.BosTarihBas = reader.GetString(5);
                        model.BosTarihSon = reader.GetString(6);
                        model.BosSaatBas = reader.GetString(7);
                        model.BosSaatSon = reader.GetString(8);


                    }
                }

                return model;


            }


        }

        public Cocuk GetCocukFromName(string name)
        {
            Cocuk model;
            model = new Cocuk();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Cocuk\" WHERE \"AdSoyad\"='{0}'", name);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        model.Id = reader.GetInt32(0);
                        model.EbeveynId = reader.GetInt32(1);
                        model.AdSoyad = reader.GetString(2);


                    }
                }

                return model;


            }


        }

        public bool CocukRandevuOlustur(Randevu randevu)
        {

            using (var conn = CreateConnection)
            {
                conn.Open();

                int count = 0;
                using (var command = new NpgsqlCommand("SELECT MAX(\"Id\") FROM \"public\".\"Randevu\"", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            count = reader.GetInt32(0);
                        }
                        catch
                        {

                            
                        }
                        
                    }
                    reader.Close();
                }


                int id = count + 1;
                randevu.Id = id;
                int nRows = -1;

                using (var cmd = new NpgsqlCommand("SELECT * FROM CocukRandevuOlustur(@q1,@q2,@q3,@q4,@q5,@q6,@q7)", conn))
                {
                    cmd.Parameters.AddWithValue("q1", randevu.Id);
                    cmd.Parameters.AddWithValue("q2", randevu.Tarih);
                    cmd.Parameters.AddWithValue("q3", randevu.DoktorId);
                    cmd.Parameters.AddWithValue("q4", randevu.UserId);
                    cmd.Parameters.AddWithValue("q5", randevu.SaglikKurumuId);
                    cmd.Parameters.AddWithValue("q6", randevu.Saat);
                    cmd.Parameters.AddWithValue("q7", randevu.CocukId);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nRows = 1;

                    }
                    // nRows = cmd.ExecuteNonQuery();


                }

                return nRows == 1;


            }



        }


        public List<Randevu> GetRandevu(int UserId)
        {
            var list = new List<Randevu>();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Randevu\" WHERE \"UserId\" = {0}", UserId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new Randevu();
                        model.Id = reader.GetInt32(0);
                        model.Tarih = reader.GetString(1);
                        model.DoktorId = reader.GetInt32(2);
                        model.UserId = reader.GetInt32(3);
                        model.SaglikKurumuId = reader.GetInt32(4);
                        model.Saat = reader.GetString(5);
                        try
                        {
                            model.CocukId = reader.GetInt32(6);
                        }
                        catch
                        {


                        }


                        list.Add(model);
                    }


                }
            }


            return list;
        }

        public Doktor GetDoktorFromId(int id)
        {
            Doktor model;
            model = new Doktor();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Doktor\" WHERE \"Id\"= {0}", id);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        try
                        {
                            model.BolumId = reader.GetInt32(2);

                        }
                        catch { }
                        try
                        {
                            model.MahId = reader.GetInt32(4);
                        }
                        catch { }
                        model.PuanId = reader.GetInt32(3);
                        model.BosTarihBas = reader.GetString(5);
                        model.BosTarihSon = reader.GetString(6);
                        model.BosSaatBas = reader.GetString(7);
                        model.BosSaatSon = reader.GetString(8);

                    }
                }
                return model;
            }
        }

        public SaglikKurumu GetSaglikKurumuFromId(int id)
        {
            SaglikKurumu model;
            model = new SaglikKurumu();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"SaglikKurumu\" WHERE \"Id\"= {0}", id);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.SehirId = reader.GetInt32(2);


                    }
                }
                return model;
            }
        }

        public Cocuk GetCocukFromId(int cocukId)
        {
            Cocuk model;
            model = new Cocuk();

            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Cocuk\" WHERE \"Id\"='{0}'", cocukId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        model.Id = reader.GetInt32(0);
                        model.EbeveynId = reader.GetInt32(1);
                        model.AdSoyad = reader.GetString(2);


                    }
                }

                return model;


            }


        }


        public bool UserUpdate(User user)
        {
            using (var conn = CreateConnection)
            {
                conn.Open();

                int nRows = -1;
                using (var cmd = new NpgsqlCommand("SELECT * FROM UserUpdate(@q1,@q2,@q3)", conn))
                {
                    cmd.Parameters.AddWithValue("q1", user.Id);
                    cmd.Parameters.AddWithValue("q2", user.Password);
                    cmd.Parameters.AddWithValue("q3", user.SehirId);


                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nRows = 1;

                    }
                }

                return nRows == 1;
            }
        }

        public bool RandevuSil(int RandevuId)
        {
            using (var conn = CreateConnection)
            {
                conn.Open();

                int nRows = -1;
                using (var cmd = new NpgsqlCommand("SELECT * FROM DeleteRandevu(@q1)", conn))
                {
                    cmd.Parameters.AddWithValue("q1", RandevuId);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nRows = 1;

                    }
                }

                return nRows == 1;
            }
        }


        public List<OzelDurum> GetOzelDurumlar()
        {
            var list = new List<OzelDurum>();

            using (var conn = CreateConnection)
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM \"public\".\"OzelDurum\"", conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var model = new OzelDurum();
                        model.Id = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        list.Add(model);
                    }
                    reader.Close();
                }

            }
            if (list.Count > 0)
                return list;
            else
                return null;
        }

        public List<string> GetDoktorSaatler(int dId)
        {
            var list = new List<string>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"DoktorRandevuSaat\" WHERE \"DoktorId\" = {0}", dId);
                using (var cmd = new NpgsqlCommand(q1, conn))
                {

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            var str = reader.GetString(2);
                            list.Add(str);
                        }
                        catch
                        {

                        }

                    }


                }
            }


            return list;
        }


        public bool TalepEkle(Talepler model)
        {
           
            int nRows = -1;
            

            using (var conn = CreateConnection)

            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();
                
                int count = 0;
                using (var command = new NpgsqlCommand("SELECT MAX(\"Id\") FROM \"public\".\"Talepler\"", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                model.Id = count + 1;
                using (var command = new NpgsqlCommand("INSERT INTO \"public\".\"Talepler\" (\"Id\",\"Text\",\"OzelDurumId\")\n Values(@q1, @q2,@q3)", conn))
                {
                    command.Parameters.AddWithValue("q1", model.Id);
                    command.Parameters.AddWithValue("q2", model.Text);
                    command.Parameters.AddWithValue("q3", model.OzelDurumId);
                    

                    nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
            }

            return nRows == 1;
        }

        public List<Talepler> GetTalepler()
        {
            var list = new List<Talepler>();
            using (var conn = CreateConnection)
            {
                conn.Open();
                string q1 = String.Format("SELECT * FROM \"public\".\"Talepler\" ");
                using (var cmd = new NpgsqlCommand(q1, conn))
                {

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            var model = new Talepler();
                            model.Id = reader.GetInt32(0);
                            model.Text = reader.GetString(1);
                            model.OzelDurumId = reader.GetInt32(2);

                           
                            list.Add(model);
                        }
                        catch
                        {

                        }

                    }


                }
            }


            return list;
        }


    }
}
