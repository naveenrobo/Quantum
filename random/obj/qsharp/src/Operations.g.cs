#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Random\",\"Name\":\"HelloQ\"},\"Attributes\":[],\"SourceFile\":\"G:/delete/quantum/random/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Random\",\"Name\":\"HelloQ\"},\"Attributes\":[],\"SourceFile\":\"G:/delete/quantum/random/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Random
{
    [SourceLocation("G:/delete/quantum/random/Operations.qs", OperationFunctor.Body, 5, -1)]
    public partial class HelloQ : Operation<QVoid, Result>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Random.HelloQ";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in__) =>
        {
#line hidden
            {
#line 7 "G:/delete/quantum/random/Operations.qs"
                var q = Allocate.Apply();
#line hidden
                System.Runtime.ExceptionServices.ExceptionDispatchInfo __arg1__ = null;
                try
                {
#line 8 "G:/delete/quantum/random/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 9 "G:/delete/quantum/random/Operations.qs"
                    var r = MicrosoftQuantumIntrinsicM.Apply(q);
#line 10 "G:/delete/quantum/random/Operations.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 11 "G:/delete/quantum/random/Operations.qs"
                    return r;
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(__arg2__);
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        __arg1__.Throw();
                    }

#line hidden
                    Release.Apply(q);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, Result>(QVoid.Instance);
        }
    }
}