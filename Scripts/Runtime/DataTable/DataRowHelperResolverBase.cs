using System;
using GameFramework.DataTable;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    public abstract class DataRowHelperResolverBase : MonoBehaviour, IDataRowHelperResolver
    {
        public abstract IDataRowHelper GetHelper(Type dataRowType);

        public virtual IDataRowHelper<T> GetHelper<T>()
        {
            return GetHelper(typeof(T)) as IDataRowHelper<T>;
        }
    }
}
