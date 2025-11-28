using NestedDependency;

namespace Dependency;

public class ClassInDependency
{
    public const string Test = ClassInNested.Test + "ClassInDependency";
}