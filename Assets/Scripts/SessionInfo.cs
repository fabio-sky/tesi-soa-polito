using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionInfo
{
    private string _name;
    public string Name { get { return _name; } set { _name = value; } }
    private string _description;
    public string Description { get { return _description; } set { _description = value; } }

    private string _identifier;
    public string Identifier { get { return _identifier; } set { _identifier = value; } }

    private DateTime _createdAt;
    public DateTime CreatedAt { get { return _createdAt; } set { _createdAt = value; } }

    private List<SessionInfo> _sessionBlocks;
    public List<SessionBlock> SessionBlocksList;

    public SessionInfo()
    {
        _name = string.Empty;
        _description = string.Empty;
        _identifier = string.Empty;
    }

    public new string ToString()
    {
        return string.Concat("{", "\"Identifier\":\"", _identifier, "\",", "\"Name\":\"", _name, "\",", "\"Description\":\"", _description, "\",", "\"CreatedAt\":\"", _createdAt.ToString(), "\"}");
    }
}
