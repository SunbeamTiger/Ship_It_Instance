There are two similar versions of this program:
1. One written using an 'instance' of the shipper class
2. One written using a 'static' (non-instance) of the shipper class.

Generally, the decision to use an instance or a static class is 
either/or. The thing that makes it possible here is based on the
need for one and only one shipper to be used. If we had to make multiple
shippers, we woudl need to make them as objects (instances) of the 
shipper class. That's the only way each can have their own seperate data.

But since we only need one shipper with one set of data, it now becomes
an option to make both the class and data within static. That one-to-one
relationship is critical to allow the option of static over instance use.

So there two versions are pretty similar.