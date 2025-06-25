using Generics;

BlockList<string> BlockList = new BlockList<string>();

BlockList.AddBlock(new ReverseBlock());
BlockList.AddBlock(new UpperCaseBlock());
BlockList.AddBlock(new ReplaceAWithSixBlock());

string r = BlockList.RunFlow("adsbvcbdaafgq");
Console.WriteLine(r);