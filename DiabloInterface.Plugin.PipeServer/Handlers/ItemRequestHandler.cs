using NLog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zutatensuppe.D2Reader;
using Zutatensuppe.D2Reader.Models;
using Zutatensuppe.D2Reader.Struct.Item;
using Zutatensuppe.DiabloInterface.Plugin.PipeServer.Server;

namespace Zutatensuppe.DiabloInterface.Plugin.PipeServer.Handlers
{
    public class ItemResponsePayload
    {
        public bool IsValidSlot { get; set; }
        public List<ItemInfo> Items { get; set; }
    }

    public class ItemRequestHandler : IRequestHandler
    {
        readonly D2DataReader dataReader;

        public ItemRequestHandler(D2DataReader dataReader)
        {
            this.dataReader = dataReader;
        }
   
        public Response HandleRequest(Request request, IList<string> arguments)
        {
            Console.WriteLine($"Received item slot request: {arguments[0]}");


            return new Response()
            {
                Status = ResponseStatus.Success,
                Payload = BuildPayload(GetItemLocations(arguments[0])),
            };
        }

        private ItemResponsePayload BuildPayload(List<BodyLocation> locations)
        {
            Console.WriteLine($"Building payload for locations: {string.Join(", ", locations)}");
            if (locations.Count == 0)
            {
                Console.WriteLine("No valid locations found for the requested item slot.");
                return new ItemResponsePayload() { IsValidSlot = false };
            }

            var itemsInRequestedSlot = dataReader.Game.Character.Items
            .FindAll(item => locations.Contains(item.Location.BodyLocation));

            Console.WriteLine($"Found {itemsInRequestedSlot.Count} items in the requested slot.");

            foreach (var item in itemsInRequestedSlot)
            {
                // Log some basic information about each item. You can add more details if necessary.
                Console.WriteLine($"Item name: {item.ItemName}");
            }

            return new ItemResponsePayload()
            {
                IsValidSlot = true,
                Items = dataReader.Game.Character.Items
                    .FindAll(item => locations.Contains(item.Location.BodyLocation)),
            };
        }

        private static List<BodyLocation> GetItemLocations(string itemSlot)
        {
            var locations = new List<BodyLocation>();
            if (string.IsNullOrEmpty(itemSlot))
                return locations;

            switch (itemSlot.Trim().ToLowerInvariant())
            {
                case "helm":
                case "head":
                    locations.Add(BodyLocation.Head);
                    break;
                case "armor":
                case "body":
                case "torso":
                    locations.Add(BodyLocation.BodyArmor);
                    break;
                case "amulet":
                    locations.Add(BodyLocation.Amulet);
                    break;
                case "ring":
                case "rings":
                    locations.Add(BodyLocation.RingLeft);
                    locations.Add(BodyLocation.RingRight);
                    break;
                case "belt":
                    locations.Add(BodyLocation.Belt);
                    break;
                case "glove":
                case "gloves":
                case "hand":
                    locations.Add(BodyLocation.Gloves);
                    break;
                case "boot":
                case "boots":
                case "foot":
                case "feet":
                    locations.Add(BodyLocation.Boots);
                    break;
                case "primary":
                case "weapon":
                    locations.Add(BodyLocation.PrimaryLeft);
                    break;
                case "offhand":
                case "shield":
                    locations.Add(BodyLocation.PrimaryRight);
                    break;
                case "weapon2":
                case "secondary":
                    locations.Add(BodyLocation.SecondaryLeft);
                    break;
                case "secondaryshield":
                case "secondaryoffhand":
                case "shield2":
                    locations.Add(BodyLocation.SecondaryRight);
                    break;
            }

            return locations;
        }
    }
}
