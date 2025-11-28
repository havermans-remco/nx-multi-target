using MultiTarget;

namespace DependingProject2;

public class ClassInDepending
{
    public const string Test = ClassInMultiTarget.Test + "ClassInMultiTarget";
}