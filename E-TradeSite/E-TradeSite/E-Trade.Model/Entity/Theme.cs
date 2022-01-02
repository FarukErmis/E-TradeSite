using E_Trade.Model.Enum;
using System;

namespace E_Trade.Model.Entity
{
    public class Theme
    {
        public int Id { get; set; }
        public ThemePlatform Platform { get; set; }
        public ThemeType Type { get; set; }
        public string Name { get; set; }
        public string Preset { get; set; }
        public string DirectoryName { get; set; }
        public bool Status { get; set; }
        public int Revision { get; set; }
        public string Version { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Attachment { get; set; }
    }
}
