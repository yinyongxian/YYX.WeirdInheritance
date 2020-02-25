namespace YYX.WeirdInheritance
{
    interface IStorage
    {
        void SetValue(string key, object value);
        object GetValue(string key);
    }
}
