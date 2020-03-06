using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "http://www.pja.edu.pl/";
            var hhtpclient = new HttpClient();
            //HttpClient hhtpclient = new HttpClient();


            var response = await hhtpclient.GetAsync(url);

            var regex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            var content = response.Content;

            var matches = regex.Matches(content.ToString());

            foreach(var match in matches )
            {
                Console.WriteLine(  match.ToString());
            }
            
        }
    }
}
