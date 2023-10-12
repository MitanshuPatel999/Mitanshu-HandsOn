using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml;

namespace linqXML{
class Program
{
    static void Main()
    {
        // Load the XML document
        XDocument doc = XDocument.Load("catalog.xml");

        // Query the XML data
        var expensiveBooks = from book in doc.Descendants("book")
                             where (decimal)book.Element("price")! > 20
                             select new
                             {
                                 Title = book.Element("title")?.Value,
                                 Author = book.Element("author")?.Value,
                                 Price = (decimal)book.Element("price")!
                             };

        Console.WriteLine("Expensive Books:");
        foreach (var book in expensiveBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }

        // Modify the XML data
        XElement firstBook = doc.Descendants("book").First();
        firstBook.Element("title")!.Value = "ABC";

        // Save the updated XML to a new file
        doc.Save("updated_books.xml");


        XmlDocument xmlDoc = new XmlDocument();

        // Create the root element
        XmlElement rootElement = xmlDoc.CreateElement("Books");
        xmlDoc.AppendChild(rootElement);

        // Create child elements
        XmlElement bookElement = xmlDoc.CreateElement("Book");
        XmlElement titleElement = xmlDoc.CreateElement("Title");
        XmlElement authorElement = xmlDoc.CreateElement("Author");
        XmlElement priceElement = xmlDoc.CreateElement("Price");

        // Set values for the child elements
        titleElement.InnerText = "Sample Book";
        authorElement.InnerText = "John Doe";
        priceElement.InnerText = "19.99";

        // Attach the child elements to the bookElement
        bookElement.AppendChild(titleElement);
        bookElement.AppendChild(authorElement);
        bookElement.AppendChild(priceElement);

        // Attach the bookElement to the root element
        rootElement.AppendChild(bookElement);
        xmlDoc.Save("newbooks.xml");
    }
}
}