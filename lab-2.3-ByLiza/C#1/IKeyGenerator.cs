public interface IKeyGenerator
{
    string GenerateKey();
    string Content { get; }
    void CapitalizeWords();
}
