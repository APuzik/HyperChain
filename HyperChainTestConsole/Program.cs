using HyperChainModel.Context;
using HyperChainModel.Enums;
using HyperChainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperChainTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new HyperChainContext())
            {
                var chains1 = from chains in db.WordChains select chains;
                db.WordChains.RemoveRange(chains1);
                var words = from word in db.Words select word;
                db.Words.RemoveRange(words);
                db.SaveChanges();
                var w1 = new RegistryWord
                {
                    SemanticId = 1,
                    Status = WordProcessedStatus.NotProcessed,
                    Word = "parent_word"
                };
                var w2 = new RegistryWord
                {
                    SemanticId = 1,
                    Status = WordProcessedStatus.NotProcessed,
                    Word = "child_word"
                };
                db.Words.Add(w1);
                db.Words.Add(w2);
                var l = db.Words.ToList();
                db.WordChains.Add(new WordChain
                {
                    AutoLink = true,
                    Child = w2,
                    Parent = w1,
                    LinkType = WordChainType.eNormal,
                });
                db.SaveChanges();

                foreach (var word in db.Words)
                {
                    Console.WriteLine($"word: {word.Id} {word.SemanticId} {word.Status} {word.Word}");
                    var chains2 = from chains in db.Words select chains;
                    //foreach (var link in word.Links)
                    //{
                    //    Console.WriteLine($"word links: {link.Id} {link.LinkType} {link.Parent.Word} {link.Child.Word} {link.ParentId}");
                    //}
                }

                foreach (var chain in db.WordChains)
                {
                    Console.WriteLine($"chain: {chain.Id} {chain.LinkType} {chain.Parent.Word} {chain.Child.Word} {chain.ParentId}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
