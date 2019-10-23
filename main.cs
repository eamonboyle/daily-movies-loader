// using Newtonsoft.Json;
using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Net;
// using System.Text;
// using System.Threading.Tasks;

namespace DMLoader
{
	class MainClass {

		// private static int current_page = 1;
		// private static int duplicatesFound = 0;
		// private static int moviesProcessed = 0;

		public static void Main (string[] args) {

			Console.WriteLine("Testing");
			return;

			
			// string current_page_txt = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testapi\\currentpage.txt";
			// string movie_titles_txt = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testapi\\movietitles.txt";
			// string insert_script_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testapi\\insert_movies_sql.txt";
			// string posters_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testapi\\posters\\";
			// string backdrop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testapi\\backdrop\\";

			// try
			// {   // Open the text file using a stream reader.
			// 		using (StreamReader sr = new StreamReader(current_page_txt))
			// 		{
			// 				// Read the stream to a string, and write the string to the console.
			// 				String current_page_str = sr.ReadToEnd();
			// 				current_page = Convert.ToInt32(current_page_str);
			// 		}
			// }
			// catch (Exception e)
			// {
			// 		Console.WriteLine("Couldn't read current page from file.");
			// }

			// for (int i = current_page; i < current_page + 30; i++)
			// {
			// 		var json = new WebClient().DownloadString("https://api.themoviedb.org/3/movie/top_rated?api_key=136b41a33dd87cc17c4fe690053dd7d6&language=en-US&page=" + i);

			// 		Rootobject ro = JsonConvert.DeserializeObject<Rootobject>(json);

			// 		foreach (Result movie in ro.results)
			// 		{
			// 				bool alreadyProcessed = false;

			// 				// check the movie isn't already in the file
			// 				using (StreamReader r = File.OpenText(movie_titles_txt))
			// 				{
			// 						string line;
			// 						while ((line = r.ReadLine()) != null)
			// 						{
			// 								if (line == movie.title)
			// 										alreadyProcessed = true;
			// 						}
			// 				}

			// 				if (!alreadyProcessed)
			// 				{

			// 						// append the movie title to the text document
			// 						using (StreamWriter w = File.AppendText(movie_titles_txt))
			// 						{
			// 								w.WriteLine(movie.title);
			// 						}

			// 						//// save the poster image
			// 						//using (WebClient client = new WebClient())
			// 						//{
			// 						//    try
			// 						//    {
			// 						//        client.DownloadFile("https://image.tmdb.org/t/p/original" + movie.poster_path, posters_path + movie.poster_path.Substring(1));
			// 						//    }
			// 						//    catch (Exception)
			// 						//    {
			// 						//        Console.WriteLine("Couldn't find image for: " + movie.title);
			// 						//    }
			// 						//}

			// 						//// save the backdrop image
			// 						//using (WebClient client = new WebClient())
			// 						//{
			// 						//    try
			// 						//    {
			// 						//        client.DownloadFile("https://image.tmdb.org/t/p/original" + movie.backdrop_path, backdrop_path + movie.backdrop_path.Substring(1));
			// 						//    }
			// 						//    catch (Exception)
			// 						//    {
			// 						//        Console.WriteLine("Couldn't find image for: " + movie.title);
			// 						//    }
			// 						//}

			// 						// append sql insert for this movie here
			// 						using (StreamWriter w = File.AppendText(insert_script_path))
			// 						{
			// 								StringBuilder insert_command = new StringBuilder();
			// 								insert_command.AppendLine("INSERT INTO [eamonboyle].[Movies]");
			// 												insert_command.AppendLine("([title]");
			// 												insert_command.AppendLine(",[themoviedb_id]");
			// 												insert_command.AppendLine(",[vote_average]");
			// 												insert_command.AppendLine(",[vote_count]");
			// 												insert_command.AppendLine(",[popularity]");
			// 												insert_command.AppendLine(",[poster_path]");
			// 												insert_command.AppendLine(",[backdrop_path]");
			// 												insert_command.AppendLine(",[original_language]");
			// 												insert_command.AppendLine(",[original_title]");
			// 												insert_command.AppendLine(",[overview]");
			// 												insert_command.AppendLine(",[release_date]");
			// 												insert_command.AppendLine(",[date_added]");
			// 												insert_command.AppendLine(",[date_updated])");
			// 									insert_command.AppendLine("VALUES");
			// 												insert_command.AppendLine("('" + movie.title.Replace("'", "''") + "'");
			// 												insert_command.AppendLine("," + movie.id.ToString());
			// 												insert_command.AppendLine("," + movie.vote_average);
			// 												insert_command.AppendLine("," + movie.vote_count);
			// 												insert_command.AppendLine("," + movie.popularity);
			// 												insert_command.AppendLine(",'" + movie.poster_path + "'");
			// 												insert_command.AppendLine(",'" + movie.backdrop_path + "'");
			// 												insert_command.AppendLine(",'" + movie.original_language + "'");
			// 												insert_command.AppendLine(",'" + movie.original_title.Replace("'", "''") + "'");
			// 												insert_command.AppendLine(",'" + movie.overview.Replace("'", "''") + "'");
			// 												insert_command.AppendLine(",'" + movie.release_date + "'");
			// 												insert_command.AppendLine(",'" + DateTime.Now + "'");
			// 												insert_command.AppendLine(",'" + DateTime.Now + "')");

			// 												insert_command.AppendLine("DECLARE @movie_id_" + movie.id + " INT");
			// 												insert_command.AppendLine("SELECT @movie_id_" + movie.id + " = SCOPE_IDENTITY()");

			// 												foreach (int movie_genre in movie.genre_ids)
			// 												{
			// 														insert_command.AppendLine("INSERT INTO [eamonboyle].[MovieGenres]");
			// 																insert_command.AppendLine("([movie_id]");
			// 																insert_command.AppendLine(",[genre_id])");
			// 																insert_command.AppendLine("VALUES");
			// 																insert_command.AppendLine("(@movie_id_" + movie.id);
			// 														insert_command.AppendLine("," + movie_genre + ")"); 
			// 												}                                   

			// 								w.WriteLine(insert_command.ToString());
			// 						}

			// 						Console.WriteLine("Added: " + movie.title);

			// 						moviesProcessed++;

			// 				}
			// 				else
			// 				{
			// 						duplicatesFound++;
			// 				}
			// 		}

			// 		// update current page
			// 		File.WriteAllText(current_page_txt, i.ToString());
			// }

			// Console.WriteLine(moviesProcessed + " movies processed, " + duplicatesFound + " duplicates found.");

			// Console.ReadKey();

		}
	}
}