namespace OrderServiceCourse.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment=0,
        Processing,
        Shipped,
        Delivered
    }
}
