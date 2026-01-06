using GameFramework.DataTable;

namespace UnityGameFramework.Runtime
{
    public class DefaultDataRowHelper<T> : DataRowHelperBase<T>
        where T : IDataRow, new()
    {
        protected override int GetId(T dataRow)
        {
            return dataRow.Id;
        }

        protected override bool ParseDataRow(out T dataRow, string dataRowString, object userData)
        {
            dataRow = new T();
            return dataRow.ParseDataRow(dataRowString, userData);
        }

        protected override bool ParseDataRow(out T dataRow, byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            dataRow = new T();
            return dataRow.ParseDataRow(dataRowBytes, startIndex, length, userData);
        }
    }
}
