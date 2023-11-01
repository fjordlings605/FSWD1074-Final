using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace burble_api.Models;

public class User
{
    //id
    [JsonIgnore, BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string? UserId { get; set; }

    //username
    [Required, BsonElement("Username")]
    public string? Username { get; set; }

    //password
    [Required, BsonElement("Password")]
    public string? Password { get; set; }

    //fname
    [Required, BsonElement("FirstName")]
    public string? FirstName { get; set; }

    //lname
    [Required, BsonElement("LastName")]
    public string? LastName { get; set; }

    //city
    [BsonElement("City")]
    public string? City { get; set; }

    //state
    [BsonElement("State")]
    public string? State { get; set; }

}