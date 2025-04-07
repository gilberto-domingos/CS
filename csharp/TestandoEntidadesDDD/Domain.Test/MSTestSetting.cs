using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Test;

[TestClass]
public static class MSTestSettings
{
    [AssemblyInitialize]
    public static void Init(TestContext context)
    {
        // Código que roda antes de todos os testes
    }

    [AssemblyCleanup]
    public static void Cleanup()
    {
        // Código que roda após todos os testes
    }
}

/* Isso seria útil, por exemplo, para conectar a um banco de testes, preparar mocks globais, etc. Não é necessário para caso agora. Verificando só como fazer teste no DDD */