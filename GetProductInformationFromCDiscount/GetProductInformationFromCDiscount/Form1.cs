using HtmlAgilityPack;
//using mshtml;
using System;
using System.Collections.Generic;
//using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
//using System.Threading;
using System.Windows.Forms;




namespace GetProductInformationFromCDiscount
{
    public partial class Form1 : Form
    {
        List<Information> listInformation;
        string yol = "Linkler.txt";
        List<string> listLink;
        public string image;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            listLink = new List<string>();
            for (int i = 1; i <= 40; i++)
            {

                string pageLink = "https://www.eastpak.com/be-nl/rugzakken/categorieen/view-all-c7708.html?p=" + i.ToString();
                webBrowser1.Navigate(pageLink);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }

                var links = webBrowser1.Document.GetElementsByTagName("a");
                foreach (HtmlElement link in links)
                {
                    if (link.GetAttribute("className") == "product-image")
                    {
                        listLink.Add(link.GetAttribute("href"));
                    }

                }


            }
            MessageBox.Show("Test");
        }

        private void btnLinkleriDosyayaKaydet_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(yol, false, Encoding.GetEncoding(1254));
            for (int i = 0; i < listLink.Count; i++)
            {
                sw.WriteLine(listLink[i]);
            }
            sw.Close();
        }

        private void btnLinkleriDosyadanOku_Click(object sender, EventArgs e)
        {
            if (!File.Exists(yol))
            {
                MessageBox.Show("Linklerin olduğu dosya bulunamadı!");
            }
            listLink = new List<string>();
            StreamReader sr = new StreamReader(yol, Encoding.GetEncoding(1254));
            while (!sr.EndOfStream)
            {
                listLink.Add(sr.ReadLine());
            }
            sr.Close();
            MessageBox.Show("Dosyadan linkler okundu!");
        }

        List<string> listDetayLink = new List<string>();
        private async void btnGetInformation_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            listInformation = new List<Information>();
            #region MyRegion
            //int a = 0;
            //this.Text = a.ToString();
            //for (int i = 0; i < listLink.Count; i++)
            //{
            //    try
            //    {
            //        this.Text = (i + 1).ToString() + "/" + listLink.Count.ToString();
            //        Application.DoEvents();
            //        var url = listLink[i];

            //        WebBrowser ws = new WebBrowser();
            //        ws.Navigate(url);
            //        while (ws.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();

            //        var element = ws.Document.GetElementsByTagName("a").Cast<HtmlElement>().Where(u => u.GetAttribute("itemprop") == "url").ToList();
            //        for (int j = 3; j < element.Count; j++)
            //        {
            //            listDetayLink.Add(element[j].GetAttribute("href"));
            //        }
            //        ws.Dispose();


            //        //string xPath = "//*[@id='productDetailsFragmentInfo']/div/div/h1/span";
            //        //if (doc.DocumentNode.SelectNodes(xPath) == null) continue;
            //        //string productTitle = doc.DocumentNode.SelectNodes(xPath).FirstOrDefault().InnerText.Trim();
            //        //productTitle = ReplaceCharacter(productTitle);


            //        //xPath = "//*[@id='specs']/div[1]/p[1]";
            //        //var description = doc.DocumentNode.SelectNodes(xPath).FirstOrDefault().InnerText.Trim();
            //        //description = ReplaceCharacter(description);

            //        //xPath = "//*[@id='image-0']";
            //        //HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xPath);
            //        //string image = nodes[0].Attributes["src"].Value.ToString();


            //        //xPath = "//*[@id='productDetailsFragmentInfo']/div/div/div[4]/div/ins/text()[1]";
            //        //var Price = doc.DocumentNode.SelectNodes(xPath).FirstOrDefault().InnerText.Trim();
            //        //Price = ReplaceCharacter(Price);

            //        //xPath = "//*[@id='specs']/div[1]/p[2]";
            //        //string Barcode = doc.DocumentNode.SelectNodes(xPath).FirstOrDefault().InnerText.Trim();
            //        //string[] words = Barcode.Split(':');
            //        //Barcode = words[1];

            //        //Information information = new Information();
            //        //information.URL = listLink[i];
            //        //information.Title = productTitle;
            //        //information.Description = description;
            //        //information.ImageUrl = image;
            //        //information.Price = Price;
            //        //information.Barcode = Barcode;
            //        //listInformation.Add(information);
            //    }
            //    catch (Exception ex)
            //    {
            //    }

            //}

            #endregion

            listDetayLink = new List<string>();
            StreamReader sr = new StreamReader("Linkler.txt");
            while (!sr.EndOfStream)
            {
                listDetayLink.Add(sr.ReadLine());
            }
            sr.Close();
            WebBrowser ws = new WebBrowser();
            //StreamWriter sw = new StreamWriter("Bilgiler.txt", true);  
            HtmlWeb web = new HtmlWeb();
            int productCode = 1109;
            for (int i = 0; i <= listDetayLink.Count; i++) //listDetayLink.Count
            {

                try
                {

                    this.Text = (i).ToString() + "/" + listDetayLink.Count.ToString();
                    Application.DoEvents();
                    var url = listDetayLink[i];


                    ws.Navigate(url);
                    ws.ScriptErrorsSuppressed = true;
                    while (ws.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();

                    var doc = web.Load(ws.Url);








                    //var sbcts = webBrowser1.Document.GetElementsByTagName("div");
                    //foreach (HtmlElement sbct in sbcts)
                    //{
                    //    if (sbct.GetAttribute("class") == "product-view-top")
                    //    {
                    //        string aaf=sbct.OuterHtml;
                    //        string s = aaf;
                    //        HtmlElement afa = sbct;
                    //        string aa;
                    //        aa = sbct.GetAttribute("span");
                    //        string deneme = aa;
                    //        if (aa != null) break;

                    //    }

                    //}

                    //string subcat = "sad";



                    //string xxPath = "/html/body/div[2]/div/div[1]/div[2]/div/div[2]/div[1]/div[1]/span";
                    //HtmlTextNode faf = null;
                    //faf = doc.DocumentNode.SelectSingleNode(xxPath) as HtmlTextNode;
                    //if (faf == null) continue;
                    //string subcat = faf.InnerText.Trim();


                    //string xxPath = "/html/body/div[2]/div/div[1]/div[2]/div/div[2]/div[1]/div[1]/span";
                    //HtmlNodeCollection faf = doc.DocumentNode.SelectNodes("");
                    //if (faf == null) continue;
                    //string subcat = faf[0].InnerText.Trim();

                    //          string subcat = doc.DocumentNode.Descendants("div")
                    //.Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("product-view-top")).First();
                    //          string dd = subcat;



                    this.image = doc.GetElementbyId("image-0").GetAttributeValue("data-srcset", "");
                    string deger = this.image.Trim();
                    int index = deger.IndexOf("400w");
                    string second = deger.Substring(0, index);
                    this.image = second;






                    string title = doc.DocumentNode.Descendants("h1")
    .Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("product-name"))
    .First().InnerText.Trim();


                    string price = doc.DocumentNode.Descendants("span")
    .Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("price"))
    .First().InnerText.Trim();


                    //                    string subcat = doc.DocumentNode.Descendants("strong")
                    //.Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("last"))
                    //.First().InnerText.Trim();


                    string description = doc.DocumentNode.Descendants("div")
  .Where(d => d.Attributes.Contains("itemprop") && d.Attributes["itemprop"].Value.Contains("description"))
  .First().InnerText.Trim();




                    string xPath = "//*[@id='tab-nav']/li[2]/section/div/dl/dd[7]";
                    HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xPath);
                    string material = nodes[0].InnerText.Trim();

                    xPath = "//*[@id='tab-nav']/li[2]/section/div/dl/dd[5]";
                    nodes = doc.DocumentNode.SelectNodes(xPath);
                    string weight = nodes[0].InnerText.Trim();



                    xPath = "//*[@id='tab-nav']/li[2]/section/div/dl/dd[4]";
                    nodes = doc.DocumentNode.SelectNodes(xPath);
                    string volume = nodes[0].InnerText.Trim();

                    xPath = "//*[@id='tab-nav']/li[2]/section/div/dl/dd[3]";
                    nodes = doc.DocumentNode.SelectNodes(xPath);
                    string deep = nodes[0].InnerText.Trim();


                    xPath = "//*[@id='tab-nav']/li[2]/section/div/dl/dd[2]";
                    nodes = doc.DocumentNode.SelectNodes(xPath);
                    string width = nodes[0].InnerText.Trim();


                    xPath = "//*[@id='tab-nav']/li[2]/section/div/dl/dd[1]";
                    nodes = doc.DocumentNode.SelectNodes(xPath);
                    string hight = nodes[0].InnerText.Trim();


                    //string image;
                    //if (doc.DocumentNode.SelectNodes(xPath) == null) image = "null";
                    //HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xPath);
                    //image = nodes[0].Attributes["src"].Value.ToString();
                    //string dd = image;

                    //var query = "//span[@class='promo-price']";
                    //var pr = doc.DocumentNode.SelectSingleNode(query);
                    //string price = pr.InnerText.Trim();
                    //int index = price.IndexOf("\n");
                    //string second = price.Substring(0, index);
                    //price = second;



                    //string xPath = "//*[@id='nav - mobile']/li[1]/div/div/div[1]/ul/li[2]/ul/li[2]/a/span";
                    //HtmlTextNode clr = null;
                    //clr = doc.DocumentNode.SelectSingleNode(xPath) as HtmlTextNode;
                    //if (clr == null) continue;
                    //string color = clr.InnerText.Trim();


                    //xPath = "//*[@id='mainContent']/div/div[1]/div[2]/div[1]/div[5]/div/div[1]/div/div[2]/dl/dd[3]/text()";
                    //HtmlTextNode typ = null;
                    //typ = doc.DocumentNode.SelectSingleNode(xPath) as HtmlTextNode;
                    //if (typ == null) continue;
                    //string type = typ.InnerText.Trim();






                    //xPath = "/html/body/div[1]/main/div/div[1]/div[1]/h1/span";
                    //nodes = doc.DocumentNode.SelectNodes(xPath);
                    //if (nodes == null) continue;
                    //string title = nodes[0].InnerText.Trim();






                    // int index = doc.DocumentNode.InnerText.IndexOf("EAN ");
                    // if (index == -1) continue;
                    // string total = doc.DocumentNode.InnerText;
                    // string substring = total.Substring(index + 66, 13);
                    // string barcode = substring;
                    // barcode = ReplaceCharacter(barcode);
                    //sw.WriteLine(barcode + ";" + listDetayLink[i] + ";" + image);

                    productCode++;
                    string newImageUrl = "https://shop.nicoleburrick.com/img/p/" + productCode.ToString() + ".jpg";
                    Information information = new Information();
                    information.URL = listDetayLink[i];
                    information.ImageUrl = this.image;
                    information.Category = "Rugzakken";
                    information.NewUrl = newImageUrl;
                    information.ProductCode = productCode.ToString();
                    information.Width = width;
                    information.Hight = hight;
                    information.Title = title;
                    information.Description = description;
                    information.Price = price;
                    information.Volume = volume;
                    information.Deep = deep;
                    information.Weight = weight;
                    information.Material = material;
                    information.Barcode = "yok";

                    listInformation.Add(information);
                    //ws.Dispose();
                }
                catch (Exception ex)
                {

                }
                //sw.Close(); 
            }
            MessageBox.Show("Finish");
        }

        private string ReplaceCharacter(string v1)
        {
            return WebUtility.HtmlDecode(v1);
        }

        private async void btnExportExcel_Click(object sender, EventArgs e)
        {
            //StreamWriter swNL = new StreamWriter("productsNL.csv", false, Encoding.Unicode);
            // StreamWriter swFR = new StreamWriter("productsFR.csv", false, Encoding.Unicode);
            StreamWriter deneme = new StreamWriter("eastpak.csv", false, Encoding.Unicode);
            for (int i = -1; i < listInformation.Count; i++)
            {
                string bilgi = "Image_URL" + "\t" + "Barcode" + "\t" + "Title" + "\t" + "Description" + "\t" + "Price" + "\t" + "Category" + "\t" + "Material" + "\t" + "Width" + "\t" + "Hight" + "\t" + "Deep" + "\t" + "Volume" + "\t" + "Weight" + "\t" + "ProductCode" + "\t" + "NicoleBirruckImageUrl";
                if (i == -1) { deneme.WriteLine(bilgi); continue; }
                Information information = listInformation[i];
                bilgi = information.ImageUrl + "\t" + information.Barcode + "\t" + information.Title + "\t" + information.Description + "\t" + information.Price + "\t" + information.Category + "\t" + information.Material + "\t" + information.Width + "\t" + information.Hight + "\t" + information.Deep + "\t" + information.Volume + "\t" + information.Weight + "\t" + information.ProductCode + "\t" + information.NewUrl;
                bilgi = WebUtility.HtmlDecode(bilgi);
                //if (listInformation[i].URL.Contains("/nl/")) swNL.WriteLine(bilgi);
                //else if (listInformation[i].URL.Contains("/fr/")) swFR.WriteLine(bilgi);
                deneme.WriteLine(bilgi);
            }
            // swNL.Close();
            // swFR.Close();
            deneme.Close();
        }

        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finish");
        }

        private void btnTakeBarcode_Click(object sender, EventArgs e)
        {
            var ab = new List<string>();
            StreamReader sr = new StreamReader("linkdeneme.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] aa = Regex.Split(line, "\t"); string findHtml = aa[0];
                if (findHtml.Contains(" "))
                    ab.Add(aa[0]);
            }
            sr.Close();
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("Linkler.txt", true, Encoding.ASCII);

                //Writeout the numbers 1 to 10 on the same line.
                for (int i = 0; i < ab.Count; i++)
                {
                    string line = ab[i];
                    if (line.Contains("/nl/") || line.Contains("/fr/"))
                        sw.WriteLine(ab[i]);
                }

                //close the file
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            MessageBox.Show("Csv okundu!");
            //for (int i = listInformation.Count - 1; i >= 0; i--)
            //{
            //    string url = listInformation[i].ImageUrl;
            //    string[] urlParticles = Regex.Split(url, "/");
            //    if (urlParticles.Length < 9)
            //    {
            //        listInformation.RemoveAt(i);
            //        continue;
            //    }
            //    string barcode = urlParticles[9];
            //    if (barcode.Length < 15)
            //    {
            //        listInformation.RemoveAt(i);
            //        continue;
            //    }
            //    barcode = barcode.Substring(barcode.Length - 13);
            //    listInformation[i].Barcode = barcode;
            //}
            //MessageBox.Show("Barkodlar alındı!");
        }

        private void btnDownloadImages_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {

                int code = 1110;
                for (int i = 0; i < listInformation.Count; i++)
                {
                    client.DownloadFile(listInformation[i].ImageUrl, "Images/" + code.ToString() + ".jpg");//listInformation[i].Barcode
                    code++;
                }
            }
            MessageBox.Show("Resimler indirildi!");
        }
    }

    class Information
    {
        public string URL { get; set; }
        public string ImageUrl { get; set; }
        // public string SubCategory { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public string Width { get; set; }
        public string Hight { get; set; }
        public string Deep { get; set; }
        public string Volume { get; set; }
        public string Weight { get; set; }
        public string Barcode { get; set; }
        public string ProductCode { get; set; }
        public string NewUrl { get; set; }
    }
}
