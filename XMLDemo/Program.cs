

using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;

public class Folders
{
    private static System.Collections.ArrayList result = new System.Collections.ArrayList();
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        IEnumerable<string> temp;
        XmlDocument xmldooc = new XmlDocument();
        xmldooc.LoadXml(xml);
        XmlNode rootnode = xmldooc.DocumentElement;
        GetNodesAttr(rootnode, startingLetter);
        temp = result.Cast<string>();
        DisplayNodes(rootnode);
        return temp;


    }
    private static void GetNodesAttr(XmlNode node, char startingLetter)
    {

        if (node.Attributes != null)
        {
            XmlAttributeCollection attrs = node.Attributes;
            foreach (XmlAttribute attr in attrs)
            {
                if (attr.Value.StartsWith(startingLetter.ToString()))
                {

                    result.Add(attr.Value);
                }
            }
        }


        XmlNodeList children = node.ChildNodes;
        foreach (XmlNode child in children)
        {
            GetNodesAttr(child, startingLetter);
        }
    }






    private static void DisplayNodes(XmlNode node)
    {
        //Print the node type, node name and node value of the node
        if (node.NodeType == XmlNodeType.Text)
        {
            Console.WriteLine("Type = [" + node.NodeType + "] Value = " + node.Value);
        }
        else
        {
            Console.WriteLine("Type = [" + node.NodeType + "] Name = " + node.Name);
        }

        //Print attributes of the node
        if (node.Attributes != null)
        {
            XmlAttributeCollection attrs = node.Attributes;
            foreach (XmlAttribute attr in attrs)
            {
                Console.WriteLine("Attribute Name = " + attr.Name + "; Attribute Value = " + attr.Value);
            }
        }

        //Print individual children of the node, gets only direct children of the node
        XmlNodeList children = node.ChildNodes;
        foreach (XmlNode child in children)
        {
            DisplayNodes(child);
        }
    }

    public static void Main(string[] args)
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";
        //  Folders.FolderNames(xml, 'u');
        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
        


        Console.ReadLine();
    }
}