using System.Collections.Generic;
using Newtonsoft.Json.Linq;
namespace PokeInfo
{
    public class Pokemon
    {
        public string name;
        public string weight;
        public string height;
        public string image;
        public string type;
        public Pokemon(Dictionary<string, object> jsonData)
        {

            JArray pop = jsonData["types"] as JArray;
            
            System.Console.WriteLine(pop.ToString());
            for(int j = 0; j < pop.Count; j++)
            {
                string stringtype = pop[j]["type"]["name"].Value<string>();
                if(type is null)
                {
                    type =stringtype;
                }
                else{
                    string multitype = $"{type} & {stringtype}";
                    type = multitype;
                }
            }
            System.Console.WriteLine(type);
            name = jsonData["name"].ToString();
            weight = jsonData["weight"].ToString();
            height = jsonData["height"].ToString();
            JObject sprites = jsonData["sprites"] as JObject;
            image = sprites.GetValue("front_default").Value<string>();
        }

    }
}