﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinManhattan
{
    public class RootObject
    {
        public string type { get; set; }
        public List<Feature> features { get; set; }

       

        public static RootObject getData() {

            string info = File.ReadAllText("../../../data.json");
            RootObject Data = JsonConvert.DeserializeObject<RootObject>(info);


            return Data;
       }

        public static void AllNeighborhoods(RootObject rootObject)
        {
            var data = rootObject.features.Select(t => t.properties);
            var allneighborhood = data.Select(n => n.neighborhood);
            foreach (var item in allneighborhood)
            {
                Console.WriteLine(item);
            }
        }

        public static void FilterEmpty(RootObject rootObject)
        {
            var data = rootObject.features.Select(t => t.properties);
            var neighborhood = data.Where(n => n.neighborhood != "").Select(n => n.neighborhood);
            foreach (var item in neighborhood)
            {
                Console.WriteLine(item);
            }
        }

        public static void Duplicates(RootObject rootObject)
        {
            var data = rootObject.features.Select(t => t.properties);
            var neighborhood = data.Select(n => n.neighborhood).Distinct();
            foreach (var item in neighborhood)
            {
                Console.WriteLine(item);
            }
        }

        public static void AllQuery(RootObject rootObject)
        {
            var data = rootObject.features.Select(t => t.properties);
            var neighborhood = data.Where(n => n.neighborhood != "").Select(n => n.neighborhood).Distinct();
            foreach (var item in neighborhood)
            {
                Console.WriteLine(item);
            }
        }

        public static void Neighborhood(RootObject rootObject)
        {
            var data = rootObject.features.Select(t => t.properties);
            var neighborhood = from properties in data
                               select properties.neighborhood;

            foreach (var item in neighborhood)
            {
                Console.WriteLine(item);
            }
        }
    }
}
