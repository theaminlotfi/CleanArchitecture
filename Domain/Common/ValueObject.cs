namespace Domain.Common;

// Learn Microsoft: https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects
public abstract class ValueObject
{
    protected abstract IEnumerable<object> GetEqualityProperties();

    public override bool Equals(object? obj)
    {
        if (obj is not ValueObject other || GetType() != other.GetType())
            return false;

        return GetEqualityProperties().SequenceEqual(other.GetEqualityProperties());
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();

        foreach (var component in GetEqualityProperties())
            hash.Add(component);

        return hash.ToHashCode();
    }

    public static bool operator ==(ValueObject left, ValueObject right)
    {
        if (left is null ^ right is null)
            return false;

        return left?.Equals(right!) != false;
    }

    public static bool operator !=(ValueObject left, ValueObject right)
    {
        return !(left == right);
    }
}