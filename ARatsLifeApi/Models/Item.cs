using System.ComponentModel.DataAnnotations;

namespace ARatsLifeApi.Models;
public class Item
{
  public int ItemId { get; set; }
  [Required(ErrorMessage = "The item needs a name!")]
  public string Name { get; set; }
  public int Value { get; set; }
  public int InventoryId { get; set; }
}