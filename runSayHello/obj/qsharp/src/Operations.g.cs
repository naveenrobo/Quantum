#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"runSayHello\",\"Name\":\"HelloQ\"},\"Attributes\":[],\"SourceFile\":\"G:/delete/quantum/runSayHello/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"runSayHello\",\"Name\":\"HelloQ\"},\"Attributes\":[],\"SourceFile\":\"G:/delete/quantum/runSayHello/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace runSayHello
{
    public partial class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "runSayHello.HelloQ";
        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 7 "G:/delete/quantum/runSayHello/Operations.qs"
            MicrosoftQuantumIntrinsicMessage.Apply("Hello quantum world!");
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }
}