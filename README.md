# Circular Buffer in C#
#### This is a Circular Buffer exercise from the C# track of exercism.io.  Goal was to make a cs class to keep a generic circular buffer of a defined length

#### Implementation code is CircularBuffer
#### Example tests from exercism where Actual is what code outputs and Expected is the expected answer:
```
    public void Overwrite_replaces_the_oldest_item_remaining_in_buffer_following_a_read()
    {
        var buffer = new CircularBuffer<int>(capacity: 3);
        buffer.Write(1);
        buffer.Write(2);
        buffer.Write(3);
        Assert.Equal(1, buffer.Read());
        buffer.Write(4);
        buffer.Overwrite(5);
        Assert.Equal(3, buffer.Read());
        Assert.Equal(4, buffer.Read());
        Assert.Equal(5, buffer.Read());
    }

```
