using System.Collections;
using Xunit;

namespace TMP
{
    public class SymbolConsequences
    {
        public bool IsSymbolConsequencesCorrect(string symbols)
        {
            var stack = new Stack();
            var charArray = symbols.ToCharArray();
            foreach (var c in charArray)
            {
                if (c == '(' | c == '[') stack.Push(c);
                else
                {
                    if (stack.Count == 0) return false;
                    char top = (char) stack.Pop();
                    if (top == '[' & c != ']' | top == '(' & c != ')') return false;
                }
            }
            return stack.Count == 0;
        }

        [Fact]
        public void test1()
        {
            Assert.True(IsSymbolConsequencesCorrect("()[]([])"));
        }

        [Fact]
        public void test2()
        {
            Assert.True(IsSymbolConsequencesCorrect("((([]()[()])))[]"));
        }

        [Fact]
        public void test3()
        {
            Assert.False(IsSymbolConsequencesCorrect("]["));
        }

        [Fact]
        public void test4()
        {
            Assert.False(IsSymbolConsequencesCorrect("([]]()"));
        }

        [Fact]
        public void test5()
        {
            Assert.False(IsSymbolConsequencesCorrect("([]"));
        }
    }
}