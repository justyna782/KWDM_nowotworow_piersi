using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using MatCode;

namespace KWDM_projekt
{
    public partial class Main : Form
    {
        private string name;
        private string id;
        List<Patient> patients = new List<Patient>();
        public Main()
        {
            InitializeComponent();
            gdcm.DataSetArrayType wynik = Find();

            cb_images.Enabled = false;
            cb_series.Enabled = false;
            cb_study.Enabled = false;
            btn_left.Visible = false;
            btn_right.Visible = false;
            for (int i = 0; i < wynik.Count; i++)
            {

                var ds = wynik[i];
                name = ds.GetDataElement(new gdcm.Tag(0x0010, 0x0010)).GetValue().toString();
                id = ds.GetDataElement(new gdcm.Tag(0x0010, 0x0020)).GetValue().toString();

                patients.Add(new Patient(name, id));
                lb_patients.Items.Add(patients[i].Name);
            }

        }


        static gdcm.DataSetArrayType Find()
        {

            // typ wyszukiwania (rozpoczynamy od pacjenta)
            gdcm.ERootType typ = gdcm.ERootType.ePatientRootType;

            // do jakiego poziomu wyszukujemy 
            gdcm.EQueryLevel poziom = gdcm.EQueryLevel.ePatient; // zobacz tez inne 

            // klucze (filtrowanie lub określenie, które dane są potrzebne)
            gdcm.KeyValuePairArrayType klucze = new gdcm.KeyValuePairArrayType();

            gdcm.Tag tag = new gdcm.Tag(0x0010, 0x0010); // 10,10 == PATIENT_NAME
            gdcm.KeyValuePairType klucz1 = new gdcm.KeyValuePairType(tag, "*"); // * == dowolne imię
            klucze.Add(klucz1);
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0020), ""));
            // zwrotnie oczekujemy wypełnionego 10,20 czyli PATIENT_ID

            // skonstruuj zapytanie
            gdcm.BaseRootQuery zapytanie = gdcm.CompositeNetworkFunctions.ConstructQuery(typ, poziom, klucze);

            // kontener na wyniki
            gdcm.DataSetArrayType wynik = new gdcm.DataSetArrayType();

            // wykonaj zapytanie
            bool stan = gdcm.CompositeNetworkFunctions.CFind(Form1.ipPACS, Form1.portPACS, zapytanie, wynik, Form1.myAET, Form1.callAET);


            return wynik;
        }

        static gdcm.DataSetArrayType Find_study(string id)
        {

            // typ wyszukiwania (rozpoczynamy od pacjenta)
            gdcm.ERootType typ = gdcm.ERootType.ePatientRootType;

            // do jakiego poziomu wyszukujemy 
            gdcm.EQueryLevel poziom = gdcm.EQueryLevel.eStudy; // zobacz tez inne 

            // klucze (filtrowanie lub określenie, które dane są potrzebne)
            gdcm.KeyValuePairArrayType klucze = new gdcm.KeyValuePairArrayType();

            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0020), id));
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0020, 0x000D), ""));    //StudyInstanceUID



            // skonstruuj zapytanie
            gdcm.BaseRootQuery zapytanie = gdcm.CompositeNetworkFunctions.ConstructQuery(typ, poziom, klucze);

            // kontener na wyniki
            gdcm.DataSetArrayType wynik = new gdcm.DataSetArrayType();

            // wykonaj zapytanie
            bool stan = gdcm.CompositeNetworkFunctions.CFind(Form1.ipPACS, Form1.portPACS, zapytanie, wynik, Form1.myAET, Form1.callAET);


            return wynik;
        }

        static gdcm.DataSetArrayType Find_series(string id, string studyInstanceUID)
        {

            // typ wyszukiwania (rozpoczynamy od pacjenta)
            gdcm.ERootType typ = gdcm.ERootType.ePatientRootType;

            // do jakiego poziomu wyszukujemy 
            gdcm.EQueryLevel poziom = gdcm.EQueryLevel.eSeries; // zobacz tez inne 

            // klucze (filtrowanie lub określenie, które dane są potrzebne)
            gdcm.KeyValuePairArrayType klucze = new gdcm.KeyValuePairArrayType();

            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0020), id));
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0020, 0x000D), studyInstanceUID));    //StudyInstanceUID
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0020, 0x000E), ""));     //SeriesInstanceUID



            // skonstruuj zapytanie
            gdcm.BaseRootQuery zapytanie = gdcm.CompositeNetworkFunctions.ConstructQuery(typ, poziom, klucze);

            // kontener na wyniki
            gdcm.DataSetArrayType wynik = new gdcm.DataSetArrayType();

            // wykonaj zapytanie
            bool stan = gdcm.CompositeNetworkFunctions.CFind(Form1.ipPACS, Form1.portPACS, zapytanie, wynik, Form1.myAET, Form1.callAET);


            return wynik;
        }

        static gdcm.DataSetArrayType Find_instances(string id, string studyInstanceUID, string seriesInstanceUID)
        {

            // typ wyszukiwania (rozpoczynamy od pacjenta)
            gdcm.ERootType typ = gdcm.ERootType.ePatientRootType;

            // do jakiego poziomu wyszukujemy 
            gdcm.EQueryLevel poziom = gdcm.EQueryLevel.eImage; // zobacz tez inne 

            // klucze (filtrowanie lub określenie, które dane są potrzebne)
            gdcm.KeyValuePairArrayType klucze = new gdcm.KeyValuePairArrayType();

            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0020), id));
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0020, 0x000D), studyInstanceUID));    //StudyInstanceUID
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0020, 0x000E), seriesInstanceUID));    //seriesInstanceUID  
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0008, 0x0018), ""));    //SOPInstanceUID  


            // skonstruuj zapytanie
            gdcm.BaseRootQuery zapytanie = gdcm.CompositeNetworkFunctions.ConstructQuery(typ, poziom, klucze);

            // kontener na wyniki
            gdcm.DataSetArrayType wynik = new gdcm.DataSetArrayType();

            // wykonaj zapytanie
            bool stan = gdcm.CompositeNetworkFunctions.CFind(Form1.ipPACS, Form1.portPACS, zapytanie, wynik, Form1.myAET, Form1.callAET);


            return wynik;
        }

        public static Bitmap[] gdcmBitmap2Bitmap(gdcm.Bitmap bmjpeg2000)
        {
            //// przekonwertuj teraz na bitmapę C#
            //uint cols = bmjpeg2000.GetDimension(0);
            //uint rows = bmjpeg2000.GetDimension(1);
            //uint layers = bmjpeg2000.GetDimension(2);

            //// wartość zwracana - tyle obrazków, ile warstw
            //Bitmap[] ret = new Bitmap[layers];

            //// bufor
            //byte[] bufor = new byte[bmjpeg2000.GetBufferLength()];
            //if (!bmjpeg2000.GetBuffer(bufor))
            //    throw new Exception("błąd pobrania bufora");

            //// w strumieniu na każdy piksel 2 bajty; tutaj LittleEndian (mnie znaczący bajt wcześniej)
            //for (uint l = 0; l < layers; l++)
            //{
            //    Bitmap X = new Bitmap((int)cols, (int)rows);
            //    double[,] Y = new double[cols, rows];
            //    double m = 0;

            //    for (int r = 0; r < rows; r++)
            //        for (int c = 0; c < cols; c++)
            //        {
            //            // współrzędne w strumieniu
            //            int j = ((int)(l * rows * cols) + (int)(r * cols) + (int)c) * 2;
            //            Y[r, c] = (double)bufor[j + 1] * 256 + (double)bufor[j];
            //            // przeskalujemy potem do wartości max.
            //            if (Y[r, c] > m)
            //                m = Y[r, c];
            //        }

            //    // wolniejsza metoda tworzenia bitmapy
            //    for (int r = 0; r < rows; r++)
            //        for (int c = 0; c < cols; c++)
            //        {
            //            int f = (int)(255 * (Y[r, c] / m));
            //            X.SetPixel(c, r, Color.FromArgb(f, f, f));
            //        }
            //    // kolejna bitmapa
            //    ret[l] = X;
            //}
            //return ret;

            uint cols = bmjpeg2000.GetDimension(0);
            uint rows = bmjpeg2000.GetDimension(1);
            uint layers = bmjpeg2000.GetDimension(2);

            Bitmap[] ret = new Bitmap[layers];

            // bufor
            byte[] bufor = new byte[bmjpeg2000.GetBufferLength()];
            if (!bmjpeg2000.GetBuffer(bufor))
                throw new Exception("błąd pobrania bufora");

            for (uint l = 0; l < layers; l++)
            {
                System.Drawing.Bitmap X = new System.Drawing.Bitmap((int)cols, (int)rows);
                double[,] Y = new double[rows, cols];
                double m = 0;

                for (int r = 0; r < rows; r++)
                    for (int c = 0; c < cols; c++)
                    {
                        int j = ((int)(l * rows * cols) + (int)(r * cols) + (int)c) * 2;
                        Y[r, c] = (double)bufor[j + 1] * 256 + (double)bufor[j];
                        if (Y[r, c] > m)
                            m = Y[r, c];
                    }
                for (int r = 0; r < rows; r++)
                    for (int c = 0; c < cols; c++)
                    {
                        int f = (int)(255 * (Y[r, c] / m));
                        X.SetPixel(c, r, Color.FromArgb(f, f, f));
                    }
                ret[l] = X;
            }
            return ret;
        
    }


        // przekonwertuj do formatu bezstratnego JPEG2000
        // na podstawie: http://gdcm.sourceforge.net/html/StandardizeFiles_8cs-example.html
        public static gdcm.Bitmap pxmap2jpeg2000(gdcm.Pixmap px)
        {
            gdcm.ImageChangeTransferSyntax change = new gdcm.ImageChangeTransferSyntax();
            change.SetForce(false);
            change.SetCompressIconImage(false);
            change.SetTransferSyntax(new gdcm.TransferSyntax(gdcm.TransferSyntax.TSType.JPEG2000Lossless));

            change.SetInput(px);
            if (!change.Change())
                throw new Exception("Nie przekonwertowano typu bitmapy na jpeg2000");

            gdcm.Bitmap outimg = change.GetOutputAsBitmap(); // dla GDCM.3.0.4

            return outimg; //change.GetOutput(); // tak było w starszych wersjach
        }
        static List<string> Move(string id, string studyInstanceUID, string seriesInstanceUID, string SOPInstanceUID)
        {
            // typ wyszukiwania (rozpoczynamy od pacjenta)
            gdcm.ERootType typ = gdcm.ERootType.ePatientRootType;

            // do jakiego poziomu wyszukujemy 
            gdcm.EQueryLevel poziom = gdcm.EQueryLevel.eImage; // zobacz inne 


            // klucze (filtrowanie lub określenie, które dane są potrzebne)
            gdcm.KeyValuePairArrayType klucze = new gdcm.KeyValuePairArrayType();
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0010, 0x0020), id));
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0020, 0x000D), studyInstanceUID));    //StudyInstanceUID
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0020, 0x0011), seriesInstanceUID));    //seriesInstanceUID  
            klucze.Add(new gdcm.KeyValuePairType(new gdcm.Tag(0x0008, 0x0018), SOPInstanceUID));    //SOPInstanceUID  



            // skonstruuj zapytanie
            gdcm.BaseRootQuery zapytanie = gdcm.CompositeNetworkFunctions.ConstructQuery(typ, poziom, klucze, gdcm.EQueryType.eMove);



            // przygotuj katalog na wyniki
            String odebrane = System.IO.Path.Combine(".", "odebrane"); // podkatalog odebrane w bieżącym katalogu
            if (!System.IO.Directory.Exists(odebrane)) // jeśli nie istnieje
                System.IO.Directory.CreateDirectory(odebrane); // utwórz go

            String dane = System.IO.Path.Combine(odebrane, System.IO.Path.GetRandomFileName()); // wygeneruj losową nazwę podkatalogu
            System.IO.Directory.CreateDirectory(dane); // i go utwórz

            // wykonaj zapytanie - pobierz do katalogu jak w zmiennej 'dane'
            bool stan = gdcm.CompositeNetworkFunctions.CMove(Form1.ipPACS, Form1.portPACS, zapytanie, Form1.portMove, Form1.myAET, Form1.callAET, dane);



            List<string> pliki = new List<string>(System.IO.Directory.EnumerateFiles(dane));
            foreach (String plik in pliki)
            {

                // MOVE + konwersja
                // przeczytaj pixele
                gdcm.PixmapReader reader = new gdcm.PixmapReader();
                reader.SetFileName(plik);
                if (!reader.Read())
                {
                    // najpewniej nie jest to obraz
                    MessageBox.Show("pomijam: " + plik, "MessageBox", MessageBoxButtons.OK);
                    continue;
                }

                // przekonwertuj na "znany format"
                gdcm.Bitmap bmjpeg2000 = pxmap2jpeg2000(reader.GetPixmap());
                // przekonwertuj na .NET bitmapę
                Bitmap[] X = gdcmBitmap2Bitmap(bmjpeg2000);
                // zapisz
                for (int i = 0; i < X.Length; i++)
                {
                    String name = String.Format("{0}_warstwa{1}.jpg", plik, i);
                    X[i].Save(name);

                }
            }
            return pliki;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cb_images.Enabled = false;
            cb_series.Enabled = false;
            cb_study.Enabled = false;
            btn_left.Visible = false;
            btn_right.Visible = false;
            cb_series.Items.Clear();
            cb_series.Text = "";
            cb_study.Items.Clear();
            cb_study.Text = "";
            cb_images.Items.Clear();
            cb_images.Text = "";
            pb_images.Image = null;

            gdcm.DataSetArrayType wynik = Find();

            for (int i = 0; i < wynik.Count; i++)
            {

                var ds = wynik[i];
                name = ds.GetDataElement(new gdcm.Tag(0x0010, 0x0010)).GetValue().toString();
                id = ds.GetDataElement(new gdcm.Tag(0x0010, 0x0020)).GetValue().toString();
                bool alreadyExists = patients.Any(x => x.Name == name && x.Id == id);
                if (!alreadyExists)
                {
                    patients.Add(new Patient(name, id));
                    lb_patients.Items.Add(patients[i].Name);
                }


            }
        }

        private void lb_patients_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_images.Enabled = false;
            cb_series.Enabled = false;
            cb_study.Enabled = false;
            btn_left.Visible = false;
            btn_right.Visible = false;

            cb_series.Items.Clear();
            cb_series.Text = "";
            cb_study.Items.Clear();
            cb_study.Text = "";
            cb_images.Items.Clear();
            cb_images.Text = "";
            pb_images.Image = null;



          
                string patient_name = lb_patients.SelectedItem.ToString();
                int index_list = patients.FindIndex(x => x.Name.Contains(patient_name));
                string patientID = patients[index_list].Id;

                gdcm.DataSetArrayType wynik_study = Find_study(patientID);
                List<string> studyInsUidList = new List<string>();

                for (int i = 0; i < wynik_study.Count; i++)
                {

                    var ds = wynik_study[i];
                    studyInsUidList.Add(ds.GetDataElement(new gdcm.Tag(0x0020, 0x000D)).GetValue().toString()); //StudyInstanceUID
                    string studyInsUid = studyInsUidList[0].Trim();
                    cb_study.Items.Add(studyInsUid);
                    cb_study.Enabled = true;

                }
           

        }
        private void cb_study_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_images.Enabled = false;
            cb_series.Enabled = false;
            btn_left.Visible = false;
            btn_right.Visible = false;

            cb_series.Items.Clear();
            cb_series.Text = "";
            cb_images.Items.Clear();
            cb_images.Text = "";
            pb_images.Image = null;

            string patient_name = lb_patients.SelectedItem.ToString();
            int index_list = patients.FindIndex(x => x.Name.Contains(patient_name));
            string patientID = patients[index_list].Id;

            string study = cb_study.SelectedItem.ToString();

            gdcm.DataSetArrayType wynik_series = Find_series(patientID, study);

            for (int i = 0; i < wynik_series.Count; i++)
            {

                var ds = wynik_series[i];
                cb_series.Items.Add(ds.GetDataElement(new gdcm.Tag(0x0020, 0x000E)).GetValue().toString()); //SeriesInstanceUID
                cb_series.Enabled = true;
            }
        }

        private void cb_series_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_images.Enabled = false;
            btn_left.Visible = false;
            btn_right.Visible = false;

            cb_images.Items.Clear();
            cb_images.Text = "";
            pb_images.Image = null;

            string patient_name = lb_patients.SelectedItem.ToString();
            int index_list = patients.FindIndex(x => x.Name.Contains(patient_name));
            string patientID = patients[index_list].Id;

            string study = cb_study.SelectedItem.ToString();
            string series = cb_series.SelectedItem.ToString();

            gdcm.DataSetArrayType wynik_instances = Find_instances(patientID, study, series);

            for (int i = 0; i < wynik_instances.Count; i++)
            {

                var ds = wynik_instances[i];
                cb_images.Items.Add(ds.GetDataElement(new gdcm.Tag(0x0008, 0x0018)).GetValue().toString()); //SOPInstanceUID
                cb_images.SelectedIndex = 0;
                cb_images.Enabled = true;
                btn_left.Visible = true;
                btn_right.Visible = true;
            }
        }

        private void cb_images_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb_images.Image = null;
            string patient_name = lb_patients.SelectedItem.ToString();
            int index_list = patients.FindIndex(x => x.Name.Contains(patient_name));
            string patientID = patients[index_list].Id;

            string study = cb_study.SelectedItem.ToString();
            string series = cb_series.SelectedItem.ToString();
            string image = cb_images.SelectedItem.ToString();



            List<string> pliki = Move(patientID, study, series, image);
            foreach (string plik in pliki)
            {


                var file = String.Format(@"{0}_warstwa0.jpg", plik);

                Image im = Image.FromFile(file);
                pb_images.Image = im;
            }
        }



        private void btn_left_Click(object sender, EventArgs e)
        {
            if (cb_images.SelectedIndex != 0)
            {
                cb_images.SelectedIndex -= 1;
            }
            else
            {
                cb_images.SelectedIndex = cb_images.Items.Count - 1;
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (cb_images.SelectedIndex != cb_images.Items.Count - 1)
            {
                cb_images.SelectedIndex += 1;
            }
            else
            {
                cb_images.SelectedIndex = 0;
            }
        }

        private void btn_segmentuj_Click(object sender, EventArgs e)
        {
            int i, j;
            Bitmap image = (Bitmap)pb_images.Image;
            int width = image.Width;
            int height = image.Height;
            Bitmap processed_image = new Bitmap(width, height);
    
            byte[,,] rgb = new byte[3, height, width];
            for (i = 0; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    rgb[0, i, j] = image.GetPixel(j, i).R;
                    rgb[1, i, j] = image.GetPixel(j, i).G;
                    rgb[2, i, j] = image.GetPixel(j, i).B;
                }
            }
            MWNumericArray narr = rgb;

            MyMatClass obj = new MyMatClass();
            MWArray u = obj.SegmentationMatlab((MWArray)narr);
            for (i = 0; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    processed_image.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(u[i + 1, j + 1, 1].ToString()), Convert.ToInt32(u[i + 1, j + 1, 2].ToString()), Convert.ToInt32(u[i + 1, j + 1, 3].ToString())));
                }
            }
            pb_images.Image = processed_image;





        }
    }
}
