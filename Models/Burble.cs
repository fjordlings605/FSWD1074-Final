using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace burble_api.Models;

public class Burble
{
    //Id
    [BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string? BurbId { get; set; }

    //username
    [BsonElement("Username")]
    public string? Username { get; set; }

    //date time
    [BsonElement("TimeDate")]
    public DateTime TimeDate { get; set; }

    //burb-message
    [Required, BsonElement("BurbTxt")]
    public string? BurbTxt { get; set; }
}