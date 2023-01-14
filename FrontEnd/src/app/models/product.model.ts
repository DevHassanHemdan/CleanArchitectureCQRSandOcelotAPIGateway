export interface IProduct {
  id: string | null;
  productName: string;
  price: number;
  description: string;
  categoryId: string;
  pictureUrl: string;
  categoryName: string;
  //  Guid CreatedBy
}
