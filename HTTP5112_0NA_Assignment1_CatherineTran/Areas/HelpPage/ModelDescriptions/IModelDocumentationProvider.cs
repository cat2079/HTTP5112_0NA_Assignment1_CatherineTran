using System;
using System.Reflection;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}