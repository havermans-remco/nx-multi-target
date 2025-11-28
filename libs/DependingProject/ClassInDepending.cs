using MultiTarget;

namespace DependingProject;

public class ClassInDepending
{
    public const string Test = ClassInMultiTarget.Test + "ClassInMultiTarget";
}