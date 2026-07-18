namespace Aequitas.Evals;

/// <summary>
/// Eval suite scaffold (spec §13). Real evals land in Phase 6; this proves the
/// Category trait keeps eval tests out of the PR gate.
/// </summary>
public class EvalSuitePlaceholder
{
    [Fact]
    [Trait("Category", "Eval")]
    public void Eval_suite_is_wired_up()
    {
        true.Should().BeTrue();
    }
}
