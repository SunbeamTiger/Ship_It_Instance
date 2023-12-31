﻿using System.Collections.Generic;

namespace Ship_It
{
    public class Shipper
    {
        private  List<IShippable> _shippingList = new List<IShippable>();

        private  int _bikeCount = 0;
        private  int _BaseballGloveCount = 0;
        private  int _LawnmowerCount = 0;
        private  int _crackersCount = 0;
        private  decimal _totalShipping;

        private  string _bicycleName = new Bicycles().Product;
        private  string _BaseballGloveName = new BaseballGlove().Product;
        private  string _lawnmowerName = new LawnMower().Product;
        private  string _crackersName = new Crackers().Product;
        public  decimal CalculateTotal()
        {
            _totalShipping = 0;
            for (int i = 0; i < _shippingList.Count; i++)
            {
                _totalShipping += _shippingList[i].ShipCost;
            }
            return _totalShipping;
        }
        private string SetName(IShippable item)
        {
            return item.Product;
        }
        public string ShippingManifest()
        {
            SetProductCount();

            string manifest = "SHIPPING MANIFEST:\n" +
                              "__________________\n"
              + "\nBICYCLES: " + _bikeCount + " " + (_bikeCount != 1 ? _bicycleName + "s" : _bicycleName)
              + "\nLAWN MOWERS: " + _LawnmowerCount + " " + (_LawnmowerCount != 1 ? _lawnmowerName + "s" : _lawnmowerName)
              + "\nBASEBALL GLOVES: " + _BaseballGloveCount + " " + (_BaseballGloveCount != 1 ? _BaseballGloveName + "s" : _BaseballGloveName)
              + "\nCRACKERS: " + _crackersCount + " " + _crackersName;
            return manifest;
        }
         
        public  void Add(IShippable item)
        {
            _shippingList.Add(item);
        }
        private int CountItemInList(List<IShippable> myList, string CountName)
        {
            int count = 0;
            foreach (IShippable item in myList)
                if (item.Product == CountName)
                    count++;
            return count;
        }
        private void SetProductCount()
        {
           _bikeCount = CountItemInList(_shippingList, _bicycleName);
           _LawnmowerCount = CountItemInList(_shippingList, _lawnmowerName);
           _crackersCount = CountItemInList(_shippingList, _crackersName);
           _BaseballGloveCount = CountItemInList(_shippingList, _BaseballGloveName);
        }
     }
}
