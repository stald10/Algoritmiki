using BracketsSystem;

public class Tests
{
    [Fact]
    public void TestOpening()
    {
        Assert.Equal(1, Brackets.check_brackets("{"));
        Assert.Equal(1, Brackets.check_brackets("{[]"));
        Assert.Equal(3, Brackets.check_brackets("{{{"));
        Assert.Equal(3, Brackets.check_brackets("[]([]"));
        Assert.Equal(3, Brackets.check_brackets("{{{[][][]"));
        Assert.Equal(6, Brackets.check_brackets("{{{{{{{((()))}"));
        Assert.Equal(5, Brackets.check_brackets("{()}{"));
    }
    [Fact]
    public void TestClosing()
    {
        Assert.Equal(1, Brackets.check_brackets("}()"));
        Assert.Equal(3, Brackets.check_brackets("()}()"));
        Assert.Equal(1, Brackets.check_brackets("}()"));
        Assert.Equal(7, Brackets.check_brackets("{[()]}}()"));
        Assert.Equal(13, Brackets.check_brackets("dasdsadsadas]]]"));
    }
    [Fact]
    public void TestSuccess()
    {
        Assert.Equal(0, Brackets.check_brackets("{}()"));
        Assert.Equal(0, Brackets.check_brackets("({}[(((())))])"));
        Assert.Equal(0, Brackets.check_brackets("()"));
        Assert.Equal(0, Brackets.check_brackets("({})"));
        Assert.Equal(0, Brackets.check_brackets("foo(bar[i]);"));
    }
    [Fact]
    public void TestPerson() 
    {
        Assert.Equal(0, Brackets.check_brackets("([](){([])})"));
        Assert.Equal(5, Brackets.check_brackets("()[]}"));
        Assert.Equal(7, Brackets.check_brackets("{{[()]]"));
        Assert.Equal(3, Brackets.check_brackets("{{{[][][]"));
        Assert.Equal(3, Brackets.check_brackets("{*{{}"));
        Assert.Equal(2, Brackets.check_brackets("[[*"));
        Assert.Equal(2, Brackets.check_brackets("{{"));
        Assert.Equal(3, Brackets.check_brackets("{{{**[][][]"));

    }

}

