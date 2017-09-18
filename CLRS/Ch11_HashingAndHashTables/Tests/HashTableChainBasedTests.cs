using NUnit.Framework;
namespace Books.CLRS.Ch11_HashingAndHashTables.Tests {
    [TestFixture]
    class HashTableChainBasedTests {
        [Test]
        public void HashTableTest1() {
            var hashTable = new HashTableChainBased<string>(10);

            hashTable.Insert("Amanda");
            hashTable.Insert("Elizabeth");
            hashTable.Insert("Anastasia");
            hashTable.Insert("Helen");
            hashTable.Insert("Elena");
            hashTable.Insert("Yulia");
            hashTable.Insert("Julia");
            hashTable.Insert("Vera");
            hashTable.Insert("Agniya");
            hashTable.Insert("Regina");

            Assert.AreEqual(false, hashTable.Search("Maxim"));
            Assert.AreEqual(true, hashTable.Search("Elena"));
        }
    }
}
