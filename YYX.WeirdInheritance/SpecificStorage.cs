namespace YYX.WeirdInheritance
{
    class SpecificStorage: Storage
    {
        public override object GetValue(string key)
        {
            if (key == @"yinyongxian")
            {
                return "贫下中农";
            }

            return base.GetValue(key);
        }
    }
}
