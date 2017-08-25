using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;
using System.Windows.Media;
//using Microsoft.VisualStudio.Language.StandardClassification;

namespace VSMerlin32.Coloring.Classification
{
    #region Format definition

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Merlin32TokenHelper.Merlin32Comment)]
    [Name("Merlin32CommentFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class CommentFormat : ClassificationFormatDefinition
    {
        public CommentFormat()
        {
            this.DisplayName = "Merlin32 - Comment"; //human readable version of the name
            this.ForegroundColor = Color.FromRgb(87, 166, 74);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Merlin32TokenHelper.Merlin32Opcode)]
    [Name("Merlin32OpcodeFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class OpcodeFormat : ClassificationFormatDefinition
    {
        public OpcodeFormat()
        {
            this.DisplayName = "Merlin32 - Opcode"; //human readable version of the name
            this.ForegroundColor = Color.FromRgb(86, 156, 214);
            // this.IsBold = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Merlin32TokenHelper.Merlin32Directive)]
    [Name("Merlin32DirectiveFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class DirectiveFormat : ClassificationFormatDefinition
    {
        public DirectiveFormat()
        {
            this.DisplayName = "Merlin32 - Directive"; //human readable version of the name
            this.ForegroundColor = Colors.DarkOrchid;
            // this.IsBold = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Merlin32TokenHelper.Merlin32DataDefine)]
    [Name("Merlin32DataDefineFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class DataDefineFormat : ClassificationFormatDefinition
    {
        public DataDefineFormat()
        {
            this.DisplayName = "Merlin32 - Definition"; //human readable version of the name
            this.ForegroundColor = Colors.DarkOrchid;
            // this.IsBold = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Merlin32TokenHelper.Merlin32Text)]
    [Name("Merlin32TextFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class TextFormat : ClassificationFormatDefinition
    {
        public TextFormat()
        {
            this.DisplayName = "Merlin32 - Text"; //human readable version of the name
            this.ForegroundColor = Color.FromRgb(214, 157, 133);
        }
    }
    #endregion //Format definition
}
