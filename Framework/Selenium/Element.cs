﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace Framework.Selenium
{
    public class Element : IWebElement, ILocatable, IWrapsElement
    {
        private readonly IWebElement _element;
        private readonly ILocatable _locatable;
        public readonly string Name;
        public By FoundBy { get; set; }

        public IWebElement Current => _element ?? throw new System.NullReferenceException("_element is null.");

        public Element(IWebElement element, string name)
        {
            _element = element;
            _locatable = element as ILocatable;
            Name = name;
        }

        public Element(IWebElement element)
        {
            _element = element;
            _locatable = element as ILocatable;
        }

        public string TagName => Current.TagName;

        public string Text => Current.Text;

        public bool Enabled => Current.Enabled;

        public bool Selected => Current.Selected;

        public Point Location => Current.Location;

        public Size Size => Current.Size;

        public bool Displayed => Current.Displayed;

        public Point LocationOnScreenOnceScrolledIntoView => _locatable.LocationOnScreenOnceScrolledIntoView;

        public ICoordinates Coordinates => _locatable.Coordinates;

        public IWebElement WrappedElement => _element;

        public void Clear()
        {
            Current.Clear();
        }

        public void Click()
        {
            FrameWork.Log.Step($"Click {Name}");
            Current.Click();
        }

        public IWebElement FindElement(By by)
        {
            return Current.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Current.FindElements(by);
        }

        public string GetAttribute(string attributeName)
        {
            return Current.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return Current.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return Current.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            FrameWork.Log.Step($"Insert {Name}");
            Current.SendKeys(text);
        }

        public void Submit()
        {
            Current.Submit();
        }
    }
}
