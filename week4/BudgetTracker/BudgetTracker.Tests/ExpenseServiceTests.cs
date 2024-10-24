using BudgetTracker.API.Service;
using BudgetTracker.Data;
using BudgetTracker.Models;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Moq;

namespace BudgetTracker.TESTS;

public class ExpenseServiceTests
{
    [Fact]
    public void GetAllExpensesReturnsNullOnEmpty()
    {
        //Arrange
        Mock<IExpenseRepo> mockRepo = new();
        ExpenseService expenseService = new(mockRepo.Object);

        List<Expense> exList = [];

        mockRepo.Setup(repo => repo.GetAllExpenses())
            .Returns(exList);

        //Act
        var result = expenseService.GetAllExpenses();
        
        //Assert
        Assert.Null(result);
    }

    [Fact]
    public void GetAllExpensesReturnsProperList()
    {
        //Arrange
        Mock<IExpenseRepo> mockRepo = new();
        ExpenseService expenseService = new(mockRepo.Object);

        List<Expense> exList = [
            new Expense {ExpenseName = "Coffee"},
            new Expense {},
            new Expense {}
        ];

        mockRepo.Setup(repo => repo.GetAllExpenses())
            .Returns(exList);

        //Act
        var result = expenseService.GetAllExpenses();
        
        //Assert
        Assert.NotNull(result);
        Assert.Equal(3, result.Count);
        Assert.Contains(result, e => e.ExpenseName!.Equals("Coffee"));
    }
}