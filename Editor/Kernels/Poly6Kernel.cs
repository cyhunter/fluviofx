using UnityEditor.VFX;
using UnityEngine;

namespace Thinksquirrel.FluvioFX.Editor.Kernels
{
    sealed class Poly6Kernel : SmoothingKernel
    {
        public Poly6Kernel(VFXExpression kernelSize) : base(kernelSize)
        { }

        protected override void CalculateFactor()
        {
            // Factor
            _factor = VFXValue.Constant(315.0f) / (VFXValue.Constant(64.0f) * VFXValue.Constant(Mathf.PI) * _kernelSize9);
        }
    }
}
