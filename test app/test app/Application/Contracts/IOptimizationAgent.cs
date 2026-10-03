namespace test_app.Application.Contracts;

internal interface IOptimizationAgent
{
    global::OptimizationResult OptimizeTrip(global::TripData trip, IReadOnlyList<global::VisitNode> nodes, int[,] matrix);
}
