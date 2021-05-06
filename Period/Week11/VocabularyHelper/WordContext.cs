using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite.Diagnostics.Internal;

namespace VocabularyHelper
{
    public class WordContext : DbContext
    {

        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            var connectionString = ConfigurationManager.ConnectionStrings["Words"].ConnectionString;
            optionsBuilder.UseSqlite(connectionString);
        }

    }

    [Index(nameof(English), nameof(Chinese), IsUnique = true)]
    public class Word
    {
        public int Id { get; set; }

        public string English { get; set; }
        public string Chinese { get; set; }
    }
}
