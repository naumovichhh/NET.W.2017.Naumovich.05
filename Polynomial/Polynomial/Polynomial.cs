using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    /// <summary>
    /// Stores polynomial coefficients and provides default operations with polynomials
    /// </summary>
    public class Polynomial
    {
        ///<summary>
        ///Cuts needless zero coefficients of top exponents
        ///</summary> 
        /// <param name="coeffsParam">Cofficients of polynomial</param>
        public Polynomial(double[] coeffsParam)
        {
            if (coeffsParam == null)
                throw new ArgumentNullException("coeffsParam");

            int i = coeffsParam.Length;
            while (true)
            {
                if (coeffsParam[i - 1] == 0)
                    --i;
                else
                    break;
            }
            coeffs = new double[i];
            Array.Copy(coeffsParam, coeffs, i);
        }
        
        public double Evaluate(double x)
        {
            double sum = 0;
            for (int i = 0; i < coeffs.Length; ++i)
            {
                sum += coeffs[i] * Math.Pow(x, i);
            }
            return sum;
        }

        public static Polynomial operator *(Polynomial x, Polynomial y)
        {
            double[] resultCoeffs = new double[x.coeffs.Length + y.coeffs.Length - 1];
            for (int i = 0; i < x.coeffs.Length; ++i)
                for (int j = 0; j < y.coeffs.Length; ++j)
                    resultCoeffs[i + j] += x.coeffs[i] * y.coeffs[j];
            return new Polynomial(resultCoeffs);
        }

        public static Polynomial operator +(Polynomial x, Polynomial y)
        {
            int maxLen = x.coeffs.Length;
            if (y.coeffs.Length > maxLen)
                maxLen = y.coeffs.Length;
            double[] resultCoeffs = new double[maxLen];
            for (int i = 0; i < maxLen; ++i)
            {
                double xVal, yVal;
                if (i < x.coeffs.Length)
                    xVal = x.coeffs[i];
                else
                    xVal = 0;
                if (i < y.coeffs.Length)
                    yVal = y.coeffs[i];
                else
                    yVal = 0;
                resultCoeffs[i] = xVal + yVal;
            }
            return new Polynomial(resultCoeffs);
        }

        public static Polynomial operator -(Polynomial x, Polynomial y)
        {
            int maxLen = x.coeffs.Length;
            if (y.coeffs.Length > maxLen)
                maxLen = y.coeffs.Length;
            double[] resultCoeffs = new double[maxLen];
            for (int i = 0; i < maxLen; ++i)
            {
                double xVal, yVal;
                if (i < x.coeffs.Length)
                    xVal = x.coeffs[i];
                else
                    xVal = 0;
                if (i < y.coeffs.Length)
                    yVal = y.coeffs[i];
                else
                    yVal = 0;
                resultCoeffs[i] = xVal - yVal;
            }
            return new Polynomial(resultCoeffs);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < coeffs.Length; ++i)
            {
                if (coeffs[i] == 0)
                    continue;
                if (i != 0)
                {
                    builder.Append(" + ");
                }
                builder.Append(coeffs[i]);
                if (i != 0)
                {
                    builder.Append("x^");
                    builder.Append(i);
                }
            }
            return builder.ToString();
        }

        public override bool Equals(object param)
        {
            Polynomial polynomial = (Polynomial)param;
            if (coeffs.Length != polynomial.Coeffs.Length)
            {
                return false;
            }         
            for (int i = 0; i < coeffs.Length; ++i)
            {
                if (coeffs[i] != polynomial.coeffs[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int result = 0;
            foreach (int num in coeffs)
            {
                result += num.GetHashCode();
            }
            return result;
        }

        public double[] Coeffs
        {
            get { return coeffs; }
        }

        private double[] coeffs;
    }
}
