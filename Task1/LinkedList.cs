using System;

class Node
{
	string data;
	Node prev;
	Node next;
    public Node(string data, Node prev, Node next)
    {
        this.data = data;
        this.prev = prev;
        this.next = next;
    }

    public override string ToString()
    {
		return "<-" + this.data.ToString() + "->";
	}
}

public class LinkedList
{
	Node first;
	Node last;

	public LinkedList()
	{
        this.first = null;
		this.last = null;
	}

	public Node GetFirst()
	{
		return this.first;
	}

	public Node GetLast()
	{
		return this.last;
	}

	public int Length()
	{
		int length = 0;
		if (this.first != null)
		{
			Node temp = this.first;
			length = 1;
			while (temp.next != null)
			{
				temp = temp.next;
				length++;
			}
			return length;
		}
		else
			return 0;
	}

	public void InsertFirst(string new_data)
	{
		Node newNode = new Node(new_data,null,this.first);
		if (head == null)
			this.last = newNode;
		else
			this.first.prev = newNode;
		this.first = newNode;
	}

	public void InsertLast(string new_data)
	{
		if (this.first == null)
			InsertFirst(new_data);
		else
		{
			Node newNode = new Node(o, last, null);
			this.last.next = newNode;
			this.last = newNode;
		}
	}

	public void InsertAfter(string new_data, Node after)
	{
		if (this.after == this.last)
		{
			InsertLast(new_data);
			return;
		}
		Node newNode = new Node(new_data, after, after.next);
		after.next.prev = newNode;
		after.next = newNode;
	}

	public void InsertBefore(string new_data, Node before)
	{
		if (before == this.first)
		{
			InsertFirst(new_data);
			return;
		}
		Node newNode = new Node(new_data, before.prev, before);
		before.prev.next = newNode;
		before.prev = newNode;
	}

	public string DeleteFirst()
	{
		if (this.first != null)
		{
			Node temp = this.first;
			this.first = this.first.next;
			if (this.first != null) this.first.prev = null;
			if (this.first == null)
				this.last = null;
			return temp.data;
		}
		else
			return null;
	}

	public string DeleteLast()
	{
		if (this.first != null)
		{
			if (this.first.next == null)
				return DeleteFirst();
			else
			{
				Node temp = this.last;
				this.last = last.prev;
				this.last.next = null;
				return temp.data;
			}
		}
		return null;
	}

	public void DeleteNode(string key)
	{
		Node current = this.first;
		if (current != null && current.data == key)
		{
			this.first = current.next;
			this.first.prev = null;
			return;
		}
		while (current != null && current.data != key)
		{
			current = current.next;
		}
		if (current == null)
		{
			return;
		}
		if (current.next != null)
		{
			current.next.prev = current.prev;
		}
		if (current.prev != null)
		{
			current.prev.next = current.next;
		}
	}

	public bool Contains(string key)
    {
        Node current = this.first;
		while (current != null)
		{
			if (current.data == key)
			{
				return true;
			}
			current = current.next;
		}
		return false;
    }

    public void PrintAllNodes()
	{
		Node current = this.first;
		if(current == null)
        {
			Console.WriteLine("The list is empty");
			return;
		}
		while (current != null)
		{
			Console.WriteLine(current.data);
			current = current.next;
		}
	}

	public void Clear()
	{
		this.first = null;
		this.last = null;
	}

    public override string ToString()
    {
		String ret = "";
		if (this.first != null)
		{
			Node temp = this.first;
			ret += temp + "<->";
			while (temp.next != null)
			{
				temp = temp.next;
				ret += temp + "<->";
			}
		}
		else
			ret = "The list is empty!";
		return ret;
	}
}



