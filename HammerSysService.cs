using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Grupo_Pommer_e_Barbosa___App
{
    public class HammerSysService
    {
        HttpClient client;
        private const string RestUrl = "http://192.168.1.147:55472/";

        public HammerSysService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<Model.Items>> GetOITMList(int LastDocEntry, int Top)
        {
            var Items = new List<Model.Items>();


            var uri = new Uri(RestUrl + @"Items/GetItems?LastDocEntry=" + LastDocEntry.ToString() + @"&Top=" + Top.ToString());

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Model.Items>>(content);
                }
            }
            catch (Exception oException)
            {

            }

            return Items;
        }

        public async Task<Model.Items> GetOITMItem(string ItemCode)
        {
            var Items = new Model.Items();

            var uri = new Uri(RestUrl + @"Items/GetItemFull?ItemCode=" + ItemCode);

            try
            {
                var response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<Model.Items>(content);
                }
            }
            catch (Exception oException)
            {

            }

            return Items;
        }

    }
}
