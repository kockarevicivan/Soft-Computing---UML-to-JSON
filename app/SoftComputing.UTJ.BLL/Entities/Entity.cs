using System.Collections.Generic;
using System.Linq;

namespace SoftComputing.UTJ.BLL.Entities
{
    public class Entity
    {
        public Entity(string entityString)
        {
            List<string> lines = entityString.Split('\n').Where(l => !string.IsNullOrEmpty(l.Trim())).ToList();

            this.Name = lines.ElementAt(0).Trim();
            lines.Remove(lines.First());

            this.Fields = new List<Field>();

            foreach (var line in lines)
            {
                this.Fields.Add(new Field(line.Trim()));
            }
        }

        public string Name;
        public List<Field> Fields;
    }
}
