namespace SortLibrary
{
    public static class BubbleSort
    {
        private static bool _swapped = true;
        private static int _n;

        public static List<T> Sort<T>(List<T> list)
        {
            var typeDictionary = new Dictionary<string, List<T>>
            {
                {"int", new List<T>() },
                {"double", new List<T>() },
                {"float", new List<T>() },
                {"char", new List<T>() },
                {"string", new List<T>() },
            };

            foreach (var item in list)
            {
                var type = item.GetType();
                if (typeDictionary.ContainsKey(type.Name))
                {
                    typeDictionary[type.Name].Add(item);
                }
            }

            foreach (var key in typeDictionary.Keys)
            {
                switch (key)
                {
                    case "int":
                        _n = typeDictionary[key].Count;
                        Bubble(typeDictionary[key] as List<int>);
                        break;
                    case "double":
                        _n = typeDictionary[key].Count;
                        Bubble(typeDictionary[key] as List<double>);
                        break;
                    case "float":
                        _n = typeDictionary[key].Count;
                        Bubble(typeDictionary[key] as List<float>);
                        break;
                    case "char":
                        _n = typeDictionary[key].Count;
                        Bubble(typeDictionary[key] as List<char>);
                        break;
                    case "string":
                        _n = typeDictionary[key].Count;
                        Bubble(typeDictionary[key] as List<string>);
                        break;
                    default:
                        break;
                }
            }

            list.Clear();
            foreach (var key in typeDictionary.Keys)
            {
                list.AddRange(typeDictionary[key]);
            }

            return list;
        }

        public static List<int> Bubble(List<int> list)
        {

            while (_swapped)
            {
                _swapped = !_swapped;
                for (int i = 0; i < _n - 1; i++)
                {

                }
            }
            return list;
        }
        public static List<double> Bubble(List<double> list)
        {

            while (_swapped)
            {
                _swapped = !_swapped;
                for (int i = 0; i < _n - 1; i++)
                {

                }
            }
            return list;
        }

        public static List<float> Bubble(List<float> list)
        {

            while (_swapped)
            {
                _swapped = !_swapped;
                for (int i = 0; i < _n - 1; i++)
                {

                }
            }
            return list;
        }

        public static List<char> Bubble(List<char> list)
        {

            while (_swapped)
            {
                _swapped = !_swapped;
                for (int i = 0; i < _n - 1; i++)
                {

                }
            }
            return list;
        }

        public static List<string> Bubble(List<string> list)
        {

            while (_swapped)
            {
                _swapped = !_swapped;
                for (int i = 0; i < _n - 1; i++)
                {

                }
            }
            return list;
        }
    }
}
