﻿namespace AsyncApostle.QuickFixes;

[QuickFix]
public class AsyncMethodNamingQuickFix : QuickFixBase
{
   #region fields

   readonly AsyncMethodNamingHighlighting _asyncMethodNamingHighlighting;

   #endregion

   #region constructors

   public AsyncMethodNamingQuickFix(AsyncMethodNamingHighlighting asyncMethodNamingHighlighting) => _asyncMethodNamingHighlighting = asyncMethodNamingHighlighting;

   #endregion

   #region properties

   public override string Text => @"Add ""Async"" suffix";

   #endregion

   #region methods

   public override bool IsAvailable(IUserDataHolder cache) => _asyncMethodNamingHighlighting.IsValid();

   protected override Action<ITextControl>? ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
   {
      var methodDeclaration = _asyncMethodNamingHighlighting.MethodDeclaration.DeclaredElement;

      if (methodDeclaration is null) return null;

      Rename(solution, new (methodDeclaration, $"{methodDeclaration.ShortName}Async"));

      return null;
   }

   #endregion
}