using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParksClient.Models
{
    public class StatePark
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public string State { get; set; }
		public string Region { get; set; }
		public string Camping { get; set; }
        public string Description { get; set; }
        public static List<StatePark> GetStateParks()
        {
            var apiCallTask = StateParksApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<StatePark> stateParkList = JsonConvert.DeserializeObject<List<StatePark>>(jsonResponse.ToString());

            return stateParkList;
        }
        public static StatePark GetDetails(int id)
        {
            var apiCallTask = StateParksApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            StatePark statePark = JsonConvert.DeserializeObject<StatePark>(jsonResponse.ToString());

            return statePark;
        }
        public static void Post(StatePark statePark)
        {
            string jsonStatePark = JsonConvert.SerializeObject(statePark);
            var apiCallTask = StateParksApiHelper.Post(jsonStatePark);
        }
        public static void Put(StatePark statePark)
        {
            string jsonStatePark = JsonConvert.SerializeObject(statePark);
            var apiCallTask = StateParksApiHelper.Put(statePark.Id, jsonStatePark);
        }
        public static void Delete(int id)
        {
            var apiCallTask = StateParksApiHelper.Delete(id);
        }
    }
}