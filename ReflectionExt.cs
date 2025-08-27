using PlasticGui.WorkspaceWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Unity.Plastic.Antlr3.Runtime;
using Unity.VisualScripting.YamlDotNet.Serialization;

namespace FancyCSharp
{
    public static class ReflectionExt
    {
        public static T GetProp<T>(this object self, string propName)
        {
            return (T)self.GetType().GetProperty(propName).GetValue(self);
        }

        public static void SetProp<T>(this object self, string propName, T value)
        {
            self.GetType().GetProperty(propName).SetValue(self, value);
        }

        public static void CallMethod(Type classType,string methodName, params object[] args)
        {
            classType.GetMethod(methodName).Invoke(null, args);
        }

        public static void CallMethod<TP1>(Type classType, string methodName, TP1 arg1)
        {
            classType.GetMethod(methodName).Invoke(null, new object[] { arg1 });
        }

        public static void CallMethod<TP1, TP2>(Type classType, string methodName, TP1 arg1, TP2 arg2)
        {
            classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2 });
        }

        public static void CallMethod<TP1, TP2, TP3>(Type classType, string methodName, TP1 arg1, TP2 arg2, TP3 arg3)
        {
            classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3 });
        }

        public static void CallMethod<TP1, TP2, TP3, TP4>(Type classType, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4)
        {
            classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3, arg4 });
        }

        public static void CallMethod<TP1, TP2, TP3, TP4, TP5>(Type classType, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5)
        {
            classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5 });
        }

        public static void CallMethod<TP1, TP2, TP3, TP4, TP5, TP6>(Type classType, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5, TP6 arg6)
        {
            classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 });
        }

        public static TRet CallMethod<TRet>(Type classType,string methodName, params object[] args)
        {
            return (TRet)classType.GetMethod(methodName).Invoke(null, args);
        }

        public static TRet CallMethod<TP1, TRet>(Type classType,string methodName, TP1 arg1)
        {
            return (TRet)classType.GetMethod(methodName).Invoke(null, new object[] { arg1 });
        }

        public static TRet CallMethod<TP1, TP2, TRet>(Type classType,string methodName, TP1 arg1, TP2 arg2)
        {
            return (TRet)classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2 });
        }

        public static TRet CallMethod<TP1, TP2, TP3, TRet>(Type classType,string methodName, TP1 arg1, TP2 arg2, TP3 arg3)
        {
            return (TRet)classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3 });
        }

        public static TRet CallMethod<TP1, TP2, TP3, TP4, TRet>(Type classType,string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4)
        {
            return (TRet)classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3, arg4 });
        }

        public static TRet CallMethod<TP1, TP2, TP3, TP4, TP5, TRet>(Type classType,string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5)
        {
            return (TRet)classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5 });
        }

        public static TRet CallMethod <TP1, TP2, TP3, TP4, TP5, TP6, TRet>(Type classType,string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5, TP6 arg6)
        {
            return (TRet)classType.GetMethod(methodName).Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 });
        }

        public static void CallMethod(this object self, string methodName, params object[] args)
        {
            self.GetType().GetMethod(methodName).Invoke(self, args);
        }

        public static void CallMethod<TP1>(this object self, string methodName, TP1 arg1)
        {
            self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1 });
        }

        public static void CallMethod<TP1, TP2>(this object self, string methodName, TP1 arg1, TP2 arg2)
        {
            self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2 });
        }

        public static void CallMethod<TP1, TP2, TP3>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3)
        {
            self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3 });
        }

        public static void CallMethod<TP1, TP2, TP3, TP4>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4)
        {
            self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3, arg4 });
        }

        public static void CallMethod<TP1, TP2, TP3, TP4, TP5>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5)
        {
            self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3, arg4, arg5 });
        }

        public static void CallMethod<TP1, TP2, TP3, TP4, TP5, TP6>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5, TP6 arg6)
        {
            self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 });
        }

        public static T CallMethod<T>(this object self, string methodName, params object[] args)
        {
            return (T)self.GetType().GetMethod(methodName).Invoke(self, args);
        }

        public static TRet CallMethod<TP1, TRet>(this object self, string methodName, TP1 arg1)
        {
            return (TRet)self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1 });
        }

        public static TRet CallMethod<TP1, TP2, TRet>(this object self, string methodName, TP1 arg1, TP2 arg2)
        {
            return (TRet)self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2 });
        }

        public static TRet CallMethod<TP1, TP2, TP3, TRet>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3)
        {
            return (TRet)self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3 });
        }

        public static TRet CallMethod<TP1, TP2, TP3, TP4, TRet>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4)
        {
            return (TRet)self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3, arg4 });
        }

        public static TRet CallMethod<TP1, TP2, TP3, TP4, TP5, TRet>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5)
        {
            return (TRet)self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3, arg4, arg5 });
        }

        public static TRet CallMethod<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this object self, string methodName, TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5, TP6 arg6)
        {
            return (TRet)self.GetType().GetMethod(methodName).Invoke(self, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 });
        }
    }

    public class StaticMethodCaller
    {
        protected Type classType;
        protected MethodInfo method;

        public StaticMethodCaller(Type classType, string methodName, params Type[] argTypes)
        {
            this.classType = classType;
            method = classType.GetMethod(methodName,argTypes);
        }

        public static StaticMethodCaller Get<TP1>(Type classType, string methodName)
        {
            return new StaticMethodCaller(classType, methodName, typeof(TP1));
        }

        public static StaticMethodCaller Get<TP1, TP2>(Type classType, string methodName)
        {
            return new StaticMethodCaller(classType, methodName, typeof(TP1), typeof(TP2));
        }

        public static StaticMethodCaller Get<TP1, TP2, TP3>(Type classType, string methodName)
        {
            return new StaticMethodCaller(classType, methodName, typeof(TP1), typeof(TP2), typeof(TP3));
        }

        public static StaticMethodCaller Get<TP1, TP2, TP3, TP4>(Type classType, string methodName)
        {
            return new StaticMethodCaller(classType, methodName, typeof(TP1), typeof(TP2), typeof(TP3), typeof(TP4));
        }

        public static StaticMethodCaller Get<TP1, TP2, TP3, TP4, TP5>(Type classType, string methodName)
        {
            return new StaticMethodCaller(classType, methodName, typeof(TP1), typeof(TP2), typeof(TP3), typeof(TP4), typeof(TP5));
        }

        public static StaticMethodCaller Get<TP1, TP2, TP3, TP4, TP5, TP6>(Type classType, string methodName)
        {
            return new StaticMethodCaller(classType, methodName, typeof(TP1), typeof(TP2), typeof(TP3), typeof(TP4), typeof(TP5), typeof(TP6));
        }

        public void Call(params object[] args)
        {
            method.Invoke(null,args);
        }

        public void Call<TP1>(TP1 arg1)
        {
            method.Invoke(null, new object[] { arg1 });
        }

        public void Call<TP1, TP2>(TP1 arg1, TP2 arg2)
        {
            method.Invoke(null, new object[] { arg1, arg2 });
        }

        public void Call<TP1, TP2, TP3>(TP1 arg1, TP2 arg2, TP3 arg3)
        {
            method.Invoke(null, new object[] { arg1, arg2, arg3 });
        }

        public void Call<TP1, TP2, TP3, TP4>(TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4)
        {
            method.Invoke(null, new object[] { arg1, arg2, arg3, arg4 });
        }

        public void Call<TP1, TP2, TP3, TP4, TP5>(TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5)
        {
            method.Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5 });
        }

        public void Call<TP1, TP2, TP3, TP4, TP5, TP6>(TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5, TP6 arg6)
        {
            method.Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 });
        }

        public TRet Call<TRet>(params object[] args)
        {
            return (TRet)method.Invoke(null,args);
        }

        public TRet Call<TP1, TRet>(TP1 arg1)
        {
            return (TRet)method.Invoke(null, new object[] { arg1 });
        }

        public TRet Call<TP1, TP2, TRet>(TP1 arg1, TP2 arg2)
        {
            return (TRet)method.Invoke(null, new object[] { arg1, arg2 });
        }

        public TRet Call<TP1, TP2, TP3, TRet>(TP1 arg1, TP2 arg2, TP3 arg3)
        {
            return (TRet)method.Invoke(null, new object[] { arg1, arg2, arg3 });
        }

        public TRet Call<TP1, TP2, TP3, TP4, TRet>(TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4)
        {
            return (TRet)method.Invoke(null, new object[] { arg1, arg2, arg3, arg4 });
        }

        public TRet Call<TP1, TP2, TP3, TP4, TP5, TRet>(TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5)
        {
            return (TRet)method.Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5 });
        }

        public TRet Call<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(TP1 arg1, TP2 arg2, TP3 arg3, TP4 arg4, TP5 arg5, TP6 arg6)
        {
            return (TRet)method.Invoke(null, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 });
        }
    }
}
