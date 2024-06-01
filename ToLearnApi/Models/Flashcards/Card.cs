﻿using System.ComponentModel.DataAnnotations;
using ToLearnApi.Models.Flashcards.LearnAndReview;

namespace ToLearnApi.Models.Flashcards;

public class Card
{
    public int Id { get; set; }
    public required string Creator { get; set; } = string.Empty;
    public required string Question { get; set; } = string.Empty;
    public required string Answer { get; set; } = string.Empty;
    public required string Description { get; set; } = string.Empty;
    public required int OrderNumber { get; set; }
    [Required]
    public int UnitId { get; set; }
    public Unit Unit { get; set; }
    public List<Item> Items { get; } = new();

    public CardDto GetDto()
    {
        return new()
        {
            Id = Id,
            Question = Question,
            Answer = Answer,
            Description = Description,
            OrderNumber = OrderNumber,
            UnitId = UnitId
        };
    }

    public void UpdateWithDto(CardDto dto)
    {
        Question = dto.Question;
        Answer = dto.Answer;
        Description = dto.Description;
    }
}
