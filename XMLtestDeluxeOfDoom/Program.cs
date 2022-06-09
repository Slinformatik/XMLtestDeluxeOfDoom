// See https://aka.ms/new-console-template for more information
using System.Xml;
using XMLtestDeluxeOfDoom;

string pathToXml = @"C:\CSharp\Xml\movies.xml";
Movies listOfAllMovies = new Movies();
XmlDocument xml = new XmlDocument();
xml.Load(pathToXml);
XmlElement root = xml.DocumentElement;
XmlNodeList title = root.GetElementsByTagName("title");
XmlNodeList director = root.GetElementsByTagName("regisseur");
XmlNodeList actors = root.GetElementsByTagName("actors");
XmlNodeList genre = root.GetElementsByTagName("genre");
XmlNodeList watchLength = root.GetElementsByTagName("watchlength");
for (int i = 0; i < title.Count; i++)
{
    listOfAllMovies.Add(
        new Movie(
            title[i].InnerText.Trim(),
        director[i].InnerText.Trim(),
        Actors.CreateActors(actors[i]),
        genre[i].InnerText.Trim()
            )); 
}
foreach(Movie m in listOfAllMovies)
{
    m.MovieInfo();
    Console.WriteLine();
}

