using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Net.Http;
using System.Xml;
using HtmlAgilityPack;
using static System.Net.WebRequestMethods;

namespace WpfApp2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region
        //private void SaveToFile_Click(object sender, RoutedEventArgs e)
        //{
        //    // Get the text from the RichTextBox
        //    //string text = new TextRange(richTextBox.Document.ContentStart, richTextbox.Document.ContentEnd).Text;
        //    string text = new TextRange(myRTB1.Document.ContentStart, myRTB1.Document.ContentEnd).Text;

        //    // Specify the file path
        //    string filePath = "output.txt";

        //    // Write the text to a file
        //    System.IO.File.WriteAllText(filePath, text);

        //    MessageBox.Show("Text saved to file successfully!");
        //}
        #endregion

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Get the text from the RichTextBox
        //    string text = new TextRange(myRTB1.Document.ContentStart, myRTB1.Document.ContentEnd).Text;

        //    // Specify the file path
        //    string filePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\output.txt";

        //    // Write the text to a file
        //    System.IO.File.WriteAllText(filePath, text);
        //    MessageBox.Show("Link saved to file successfully!");

        //    // Read the URL from the file
        //    string url = System.IO.File.ReadAllText(filePath);

        //    // Check if the URL is valid
        //    if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
        //    {
        //        // Open the URL in a web browser
        //        System.Diagnostics.Process.Start(url);

        //        try
        //        {
        //            // Fetch the HTML content of the website
        //            string htmlContent = await GetHtmlContent(url);

        //            // Load HTML content into HtmlDocument
        //            HtmlDocument htmlDocument = new HtmlDocument();
        //            htmlDocument.LoadHtml(htmlContent);

        //            // Select all <h2> elements with class="woocommerce-loop-product_title"
        //            var titleNodes = htmlDocument.DocumentNode.SelectNodes("//h2[@class='woocommerce-loop-product_title']");

        //            // Select all <bdi> elements
        //            var priceNodes = htmlDocument.DocumentNode.SelectNodes("//bdi");

        //            // Create or open a text file to write the results
        //            using (StreamWriter writer = new StreamWriter(@"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\price_title_output.txt"))
        //            {
        //                // Check if both title and price nodes are found
        //                if (titleNodes != null && priceNodes != null)
        //                {
        //                    // Iterate over the title nodes and corresponding price nodes
        //                    for (int i = 0; i < Math.Min(titleNodes.Count, priceNodes.Count); i++)
        //                    {
        //                        // Get the inner text of the title node
        //                        string title = titleNodes[i].InnerText.Trim();

        //                        // Get the inner text of the price node
        //                        string price = priceNodes[i].InnerText.Trim();

        //                        // Write the title and price to the text file
        //                        writer.WriteLine($"Title: {title}, Price: {price}");
        //                    }
        //                }
        //                else
        //                {
        //                    // Handle case where either title or price nodes are not found
        //                    writer.WriteLine("Title or price not found.");
        //                }
        //            }

        //            //// Get the inspect element (outer HTML) of an element with id "inspectElementId"
        //            //HtmlNode inspectElementNode = htmlDocument.DocumentNode; //GetElementbyId("inspectElementId");

        //            //if (inspectElementNode != null)
        //            //{
        //            //    //// Parse out data inside the tags
        //            //    //string innerText = inspectElementNode.InnerText;
        //            //    //// Get the inner text of the node
        //            //    //string innerHtml = inspectElementNode.InnerHtml;
        //            //    //// Get the inner HTML of the node

        //            //    //// Specify the file paths for saving inner text and inner HTML
        //            //    //string innerTextFilePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\inner_text.txt";
        //            //    //string innerHtmlFilePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\inner_html.txt";

        //            //    // Extract product title and price
        //            //    string productTitle = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='woocommerce-loop-product_title']").InnerText;
        //            //    string price = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='woocommerce-Price-amount amount']").InnerText;

        //            //    string productTitleFilePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\product_title.txt";
        //            //    string priceFilePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\price.txt";

        //            //    //// Save the inspect element to a file
        //            //    //string inspectElement = inspectElementNode.OuterHtml;
        //            //    //string filePath_html = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\inspect_element.txt";

        //            //    System.IO.File.WriteAllText(productTitleFilePath, productTitle);
        //            //    System.IO.File.WriteAllText(priceFilePath, price);

        //            //    //File.WriteAllText(productTitleFilePath, productTitle);
        //            //    //File.WriteAllText(priceFilePath, price);

        //            //    //// Write inner text and inner HTML to files
        //            //    //File.WriteAllText(innerTextFilePath, innerText);
        //            //    //File.WriteAllText(innerHtmlFilePath, innerHtml);


        //            //    //File.WriteAllText(filePath_html, inspectElement);

        //            //    MessageBox.Show("Data saved to file successfully!");
        //            //}
        //            //else
        //            //{
        //            //    MessageBox.Show("Inspect element not found on the page.");
        //            //}
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid URL in the file.");
        //    }

        //}

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the text from the RichTextBox
            string url = new TextRange(myRTB1.Document.ContentStart, myRTB1.Document.ContentEnd).Text.Trim();

            // Check if the URL is valid
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) &&
                (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                try
                {
                    // Fetch the HTML content of the website
                    string htmlContent = await GetHtmlContent(url);
                    
                    // Load HTML content into HtmlDocument
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(htmlContent);

                    // Select all <h2> elements with class="woocommerce-loop-product__title"
                    var titleNodes = htmlDocument.DocumentNode.SelectNodes("//h2[@class='woocommerce-loop-product__title']");

                    // Select all <bdi> elements
                    var priceNodes = htmlDocument.DocumentNode.SelectNodes("//bdi");

                    // Create or open a text file to write the results
                    string outputFilePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\price_title_output.txt";
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        //writer.WriteLine(htmlContent);
                        // Check if both title and price nodes are found
                        if (titleNodes != null && priceNodes != null)
                        {
                            // Iterate over the title nodes and corresponding price nodes
                            for (int i = 0; i < Math.Min(titleNodes.Count, priceNodes.Count); i++)
                            {
                                // Get the inner text of the title node
                                string title = titleNodes[i].InnerText.Trim();

                                // Get the inner text of the price node
                                string price = priceNodes[i].InnerText.Trim();

                                // Write the title and price to the text file
                                writer.WriteLine($"Title: {title}, Price: {price}");
                            }
                        }
                        else
                        {
                            // Handle case where either title or price nodes are not found
                            writer.WriteLine("Title or price not found.");
                        }
                    }

                    MessageBox.Show("Data saved to file successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Invalid URL.");
            }
        }


        private async Task<string> GetHtmlContent(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Send a GET request to the URL
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read and return the HTML content
                return await response.Content.ReadAsStringAsync();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read HTML content from the text file
                string filePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\inspect_element.txt";
                string htmlContent = System.IO.File.ReadAllText(filePath);

                // Load HTML content into an HtmlDocument object
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlContent);

                // Create a HashSet to store unique tag names
                HashSet<string> uniqueTagNames = new HashSet<string>();

                // Select all nodes in the HTML document
                IEnumerable<HtmlNode> nodes = htmlDocument.DocumentNode.Descendants();
                if (nodes != null)
                {
                    // Iterate over each node
                    foreach (HtmlNode node in nodes)
                    {
                        // Add the tag name of the node to the HashSet
                        uniqueTagNames.Add(node.Name);
                    }
                }

                // Create a StringBuilder to store unique tag names
                StringBuilder uniqueTags = new StringBuilder();

                // Append unique tag names to the StringBuilder
                foreach (string tagName in uniqueTagNames)
                {
                    uniqueTags.AppendLine(tagName);
                }

                // Save the unique tag names to another text file
                string outputFilePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\unique_tags.txt";
                System.IO.File.WriteAllText(outputFilePath, uniqueTags.ToString());

                MessageBox.Show("Unique tag names saved to file successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read HTML content from the text file
                string filePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\inspect_element.txt";
                string htmlContent = System.IO.File.ReadAllText(filePath);

                // Load HTML content into an HtmlDocument object
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlContent);

                // Create a StringBuilder to store extracted tags
                StringBuilder extractedTags = new StringBuilder();

                // Select all nodes in the HTML document
                IEnumerable<HtmlNode> nodes = htmlDocument.DocumentNode.Descendants();
                if (nodes != null)
                {
                    // Iterate over each node
                    foreach (HtmlNode node in nodes)
                    {
                        // Append the tag name of the node to the StringBuilder
                        extractedTags.AppendLine(node.Name);
                    }
                }

                // Save the extracted tags to another text file
                string outputFilePath = @"C:\Users\apaug\OneDrive\Desktop\PP4\WpfApp2\ununique_tags.txt";
                System.IO.File.WriteAllText(outputFilePath, extractedTags.ToString());

                MessageBox.Show("All tags saved to file successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

    }

}
