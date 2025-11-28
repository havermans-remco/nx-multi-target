using Dependency;

namespace MultiTarget;

public class ClassInMultiTarget
{
    public const string Test = ClassInDependency.Test + "ClassInMultiTarget";
}