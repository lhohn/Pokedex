using NUnit.Framework;
using Pokedex.Backend.Repo;
using Pokedex.Backend.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.NTesting.Backend
{
    
    class IPokeRepositoryTests
    {
        private IPokeRepository _pr;
         PokeData pd = new PokeData();
        [SetUp]
        
        void setUp(IPokeRepository repo)
        {
            _pr = repo;
        }
        [Test]
        [TestCase(new TestCaseData(new PokeData()))]
        void testGetPokemon(IPokeRepository pr)
        {
            pr = _pr;
        }
    }
}
