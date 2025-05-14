using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphicEditorKhmylko.classes.serialization
{
    internal class Serialization
    {
        public bool SaveShapesToJson(List<baseShape> shapes, string path)
        {
            try
            {
                var shapesData = shapes.Select(shape =>
                {
                    dynamic obj = new System.Dynamic.ExpandoObject();
                    obj.Type = shape.GetType().Name;

                    // Автоматически собираем все свойства с атрибутом JsonProperty
                    var properties = shape.GetType()
                        .GetProperties()
                        .Where(p => p.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Any());

                    foreach (var prop in properties)
                    {
                        ((IDictionary<string, object>)obj)[prop.Name] = prop.GetValue(shape);
                    }

                    return obj;
                }).ToList();

                string jsonData = JsonConvert.SerializeObject(shapesData, Formatting.Indented);
                File.WriteAllText(path, jsonData);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}